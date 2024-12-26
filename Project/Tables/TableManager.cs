using EldanToolkit.Shared;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using WildStar.GameTable;
using WildStar.TextTable;

namespace EldanToolkit.Project
{
    public class TableManager
    {
        private Project proj;

		private readonly Dictionary<GameTableName, Task<DataTable>> _tableTasks = new();
		private readonly Dictionary<GameTableName, DataTable> _loadedTables = new();

        private readonly SemaphoreSlim _semaphore = new SemaphoreSlim(1, 1);

        public TableManager(Project proj)
        {
            this.proj = proj;
        }

		public async Task<DataTable> GetTableAsync(GameTableName tableName)
        {
            if (_loadedTables.TryGetValue(tableName, out var table))
            {
                // Table is already loaded
                return table;
            }

            Task<DataTable> loadTask;

            await _semaphore.WaitAsync();
            try
            {
                // Recheck inside the critical section
				if (_loadedTables.TryGetValue(tableName, out table))
				{
					return table; // Another thread completed loading while we were waiting
				}

				if (!_tableTasks.TryGetValue(tableName, out loadTask))
				{
					// Not currently loading, so start doing that now
					loadTask = LoadTableAsync(tableName);

					// Add the load task to the dictionary
					_tableTasks[tableName] = loadTask;
				}
			}
            finally
			{
				_semaphore.Release();
			}

            return await loadTask;
        }

        private async Task<DataTable> LoadTableAsync(GameTableName name)
		{
            string fullPath = GetTableCacheLocation(name);
            if (!File.Exists(fullPath) && !AddToCache(name))
            {
                throw new FileNotFoundException($"Table file not found: {fullPath}");
            }

			DataTable tbl;
            if (GameTableUtil.IsLocalization(name))
            {
                tbl = TextTableLoader.Load(fullPath);
                tbl.TableName = name;
            }
            else
            {
                tbl = GameTableLoader.Load(fullPath);
				tbl.TableName = name;
			}
            _loadedTables[name] = tbl;
            return tbl;
		}

        public string GetTableCacheLocation(GameTableName name)
        {
            return $"{proj.FileSystem.fileCachePath}/{GameTableUtil.GetDefaultFilePath(name)}";
		}

        public bool AddToCache(GameTableName name)
        {
            return proj.FileSystem.ExtractFileToLocation(GameTableUtil.GetDefaultFilePath(name), GetTableCacheLocation(name));
        }
    }
}
