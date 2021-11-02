using System.Collections.Generic;
using System.Threading.Tasks;
using DST.Domain.Entities;

namespace DST.Domain.Repositories
{
    public interface IDictionariesRepository
    {
        /// <summary>
        /// 辞書を新規登録します。
        /// </summary>
        /// <param name="dictionary">新規登録する辞書</param>
        /// <returns>新規登録された辞書</returns>
        public Task<DictionaryEntity> CreateDictionary(DictionaryEntity dictionary);

        /// <summary>
        /// すべての辞書を取得します。
        /// </summary>
        /// <returns>すべての辞書</returns>
        public Task<IEnumerable<DictionaryEntity>> GetAllDictionaries();

        /// <summary>
        /// 指定されたIDの辞書を削除します。
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>削除件数</returns>
        public Task<int> DeleteDictionary(int id);

        /// <summary>
        /// 指定されたIDの辞書を取得します。
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>辞書</returns>
        public Task<DictionaryEntity> GettDictionary(int id);

        /// <summary>
        /// 指定された辞書を更新します。
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="dictionary">更新する辞書</param>
        /// <returns>更新された辞書</returns>
        public Task<DictionaryEntity> UpdateDictionary(int id, DictionaryEntity dictionary);
    }
}