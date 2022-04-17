using BenXin.Blog.Project.IRepository;
using BenXin.Blog.Project.IRepository.UnitOfWork;
using BenXin.Blog.Project.Model.ViewModel;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BenXin.Blog.Project.Repository
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class, new()
    {
        private readonly SqlSugarScope _dbBase;

        protected BaseRepository(IUnitOfWork unitOfWork)
        {
            _dbBase = unitOfWork.GetDbClient();
        }

        private ISqlSugarClient DbBaseClient => _dbBase;

        protected ISqlSugarClient DbClient => DbBaseClient;

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="entity">实体类</param>
        /// <returns></returns>
        public bool Delete(T entity)
        {
            return DbBaseClient.Deleteable(entity).ExecuteCommandHasChange();
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="entity">实体类</param>
        /// <returns></returns>
        public async Task<bool> DeleteAsync(T entity)
        {
            return await DbBaseClient.Deleteable(entity).ExecuteCommandHasChangeAsync();
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="entity">实体类</param>
        /// <returns></returns>
        public bool Delete(IEnumerable<T> entity)
        {
            return DbBaseClient.Deleteable<T>(entity).ExecuteCommandHasChange();
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="entity">实体类</param>
        /// <returns></returns>
        public async Task<bool> DeleteAsync(IEnumerable<T> entity)
        {
            return await DbBaseClient.Deleteable<T>(entity).ExecuteCommandHasChangeAsync();
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="where">过滤条件</param>
        /// <returns></returns>
        public bool Delete(Expression<Func<T, bool>> where)
        {
            return DbBaseClient.Deleteable(where).ExecuteCommandHasChange();
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="where">过滤条件</param>
        /// <returns></returns>
        public async Task<bool> DeleteAsync(Expression<Func<T, bool>> where)
        {
            return await DbBaseClient.Deleteable(where).ExecuteCommandHasChangeAsync();
        }

        /// <summary>
        /// 删除指定ID的数据
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns></returns>
        public bool DeleteById(object id)
        {
            return DbBaseClient.Deleteable<T>(id).ExecuteCommandHasChange();
        }

        /// <summary>
        /// 删除指定ID的数据
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns></returns>
        public async Task<bool> DeleteByIdAsync(object id)
        {
            return await DbBaseClient.Deleteable<T>(id).ExecuteCommandHasChangeAsync();
        }

        /// <summary>
        /// 删除指定ID集合的数据(批量删除)
        /// </summary>
        /// <param name="ids">id集合</param>
        /// <returns></returns>
        public bool DeleteByIds(int[] ids)
        {
            return DbBaseClient.Deleteable<T>().In(ids).ExecuteCommandHasChange();
        }

        /// <summary>
        /// 删除指定ID集合的数据(批量删除)
        /// </summary>
        /// <param name="ids">id集合</param>
        /// <returns></returns>
        public async Task<bool> DeleteByIdsAsync(int[] ids)
        {
            return await DbBaseClient.Deleteable<T>().In(ids).ExecuteCommandHasChangeAsync();
        }

        /// <summary>
        /// 删除指定ID集合的数据(批量删除)
        /// </summary>
        /// <param name="ids">id集合</param>
        /// <returns></returns>
        public bool DeleteByIds(long[] ids)
        {
            return DbBaseClient.Deleteable<T>().In(ids).ExecuteCommandHasChange();
        }

        /// <summary>
        /// 删除指定ID集合的数据(批量删除)
        /// </summary>
        /// <param name="ids">id集合</param>
        /// <returns></returns>
        public async Task<bool> DeleteByIdsAsync(long[] ids)
        {
            return await DbBaseClient.Deleteable<T>().In(ids).ExecuteCommandHasChangeAsync();
        }

        /// <summary>
        /// 删除指定ID集合的数据(批量删除)
        /// </summary>
        /// <param name="ids">id集合</param>
        /// <returns></returns>
        public bool DeleteByIds(Guid[] ids)
        {
            return DbBaseClient.Deleteable<T>().In(ids).ExecuteCommandHasChange();
        }

        /// <summary>
        /// 删除指定ID集合的数据(批量删除)
        /// </summary>
        /// <param name="ids">id集合</param>
        /// <returns></returns>
        public async Task<bool> DeleteByIdsAsync(Guid[] ids)
        {
            return await DbBaseClient.Deleteable<T>().In(ids).ExecuteCommandHasChangeAsync();
        }

        /// <summary>
        /// 删除指定ID集合的数据(批量删除)
        /// </summary>
        /// <param name="ids">id集合</param>
        /// <returns></returns>
        public bool DeleteByIds(string[] ids)
        {
            return DbBaseClient.Deleteable<T>().In(ids).ExecuteCommandHasChange();
        }

        /// <summary>
        /// 删除指定ID集合的数据(批量删除)
        /// </summary>
        /// <param name="ids">id集合</param>
        /// <returns></returns>
        public async Task<bool> DeleteByIdsAsync(string[] ids)
        {
            return await DbBaseClient.Deleteable<T>().In(ids).ExecuteCommandHasChangeAsync();
        }

        /// <summary>
        /// 删除指定ID集合的数据(批量删除)
        /// </summary>
        /// <param name="ids">id集合</param>
        /// <returns></returns>
        public bool DeleteByIds(List<int> ids)
        {
            return DbBaseClient.Deleteable<T>().In(ids).ExecuteCommandHasChange();
        }

        /// <summary>
        /// 删除指定ID集合的数据(批量删除)
        /// </summary>
        /// <param name="ids">id集合</param>
        /// <returns></returns>
        public async Task<bool> DeleteByIdsAsync(List<int> ids)
        {
            return await DbBaseClient.Deleteable<T>().In(ids).ExecuteCommandHasChangeAsync();
        }

        /// <summary>
        /// 删除指定ID集合的数据(批量删除)
        /// </summary>
        /// <param name="ids">id集合</param>
        /// <returns></returns>
        public bool DeleteByIds(List<string> ids)
        {
            return DbBaseClient.Deleteable<T>().In(ids).ExecuteCommandHasChange();
        }

        /// <summary>
        /// 删除指定ID集合的数据(批量删除)
        /// </summary>
        /// <param name="ids">id集合</param>
        /// <returns></returns>
        public async Task<bool> DeleteByIdsAsync(List<string> ids)
        {
            return await DbBaseClient.Deleteable<T>().In(ids).ExecuteCommandHasChangeAsync();
        }

        /// <summary>
        /// 删除指定ID集合的数据(批量删除)
        /// </summary>
        /// <param name="ids">id集合</param>
        /// <returns></returns>
        public bool DeleteByIds(List<Guid> ids)
        {
            return DbBaseClient.Deleteable<T>().In(ids).ExecuteCommandHasChange();
        }

        /// <summary>
        /// 删除指定ID集合的数据(批量删除)
        /// </summary>
        /// <param name="ids">id集合</param>
        /// <returns></returns>
        public async Task<bool> DeleteByIdsAsync(List<Guid> ids)
        {
            return await DbBaseClient.Deleteable<T>().In(ids).ExecuteCommandHasChangeAsync();
        }

        /// <summary>
        /// 删除指定ID集合的数据(批量删除)
        /// </summary>
        /// <param name="ids">id集合</param>
        /// <returns></returns>
        public bool DeleteByIds(List<long> ids)
        {
            return DbBaseClient.Deleteable<T>().In(ids).ExecuteCommandHasChange();
        }

        /// <summary>
        /// 删除指定ID集合的数据(批量删除)
        /// </summary>
        /// <param name="ids">id集合</param>
        /// <returns></returns>
        public async Task<bool> DeleteByIdsAsync(List<long> ids)
        {
            return await DbBaseClient.Deleteable<T>().In(ids).ExecuteCommandHasChangeAsync();
        }

        /// <summary>
        /// 判断数据是否存在
        /// </summary>
        /// <param name="predicate">条件表达式树</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns></returns>
        public bool Exists(Expression<Func<T, bool>> predicate, bool blUseNoLock = false)
        {
            return blUseNoLock
              ? DbBaseClient.Queryable<T>().Where(predicate).With(SqlWith.NoLock).Any()
              : DbBaseClient.Queryable<T>().Where(predicate).Any();
        }

        /// <summary>
        /// 判断数据是否存在
        /// </summary>
        /// <param name="predicate">条件表达式树</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns></returns>
        public async Task<bool> ExistsAsync(Expression<Func<T, bool>> predicate, bool blUseNoLock = false)
        {
            return blUseNoLock
              ? await DbBaseClient.Queryable<T>().Where(predicate).With(SqlWith.NoLock).AnyAsync()
              : await DbBaseClient.Queryable<T>().Where(predicate).AnyAsync();
        }

        /// <summary>
        /// 获取数据总数
        /// </summary>
        /// <param name="predicate">条件表达式树</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns></returns>
        public int GetCount(Expression<Func<T, bool>> predicate, bool blUseNoLock = false)
        {
            return blUseNoLock
              ? DbBaseClient.Queryable<T>().With(SqlWith.NoLock).Count()
              : DbBaseClient.Queryable<T>().Count();
        }

        /// <summary>
        /// 获取数据总数
        /// </summary>
        /// <param name="predicate">条件表达式树</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns></returns>
        public async Task<int> GetCountAsync(Expression<Func<T, bool>> predicate, bool blUseNoLock = false)
        {
            return blUseNoLock
                ? await DbBaseClient.Queryable<T>().With(SqlWith.NoLock).CountAsync(predicate)
                : await DbBaseClient.Queryable<T>().CountAsync(predicate);
        }

        /// <summary>
        /// 获取数据某个字段的合计
        /// </summary>
        /// <param name="predicate">条件表达式树</param>
        /// <param name="field">字段</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns></returns>
        public int GetSum(Expression<Func<T, bool>> predicate, Expression<Func<T, int>> field, bool blUseNoLock = false)
        {
            return blUseNoLock
              ? DbBaseClient.Queryable<T>().Where(predicate).With(SqlWith.NoLock).Sum(field)
              : DbBaseClient.Queryable<T>().Where(predicate).Sum(field);
        }

        /// <summary>
        /// 获取数据总数
        /// </summary>
        /// <param name="predicate">条件表达式树</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns></returns>
        public async Task<int> GetSumAsync(Expression<Func<T, bool>> predicate, Expression<Func<T, int>> field, bool blUseNoLock = false)
        {
            return blUseNoLock
                      ? await DbBaseClient.Queryable<T>().Where(predicate).With(SqlWith.NoLock).SumAsync(field)
                      : await DbBaseClient.Queryable<T>().Where(predicate).SumAsync(field);
        }

        /// <summary>
        ///     获取数据某个字段的合计
        /// </summary>
        /// <param name="predicate">条件表达式树</param>
        /// <param name="field">字段</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns></returns>
        public decimal GetSum(Expression<Func<T, bool>> predicate, Expression<Func<T, decimal>> field,
            bool blUseNoLock = false)
        {
            return blUseNoLock
                ? DbBaseClient.Queryable<T>().Where(predicate).With(SqlWith.NoLock).Sum(field)
                : DbBaseClient.Queryable<T>().Where(predicate).Sum(field);
        }

        /// <summary>
        /// 获取数据某个字段的合计
        /// </summary>
        /// <param name="predicate">条件表达式树</param>
        /// <param name="field">字段</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns></returns>
        public async Task<decimal> GetSumAsync(Expression<Func<T, bool>> predicate, Expression<Func<T, decimal>> field,
            bool blUseNoLock = false)
        {
            return blUseNoLock
                ? await DbBaseClient.Queryable<T>().Where(predicate).With(SqlWith.NoLock).SumAsync(field)
                : await DbBaseClient.Queryable<T>().Where(predicate).SumAsync(field);
        }

        /// <summary>
        ///     获取数据某个字段的合计
        /// </summary>
        /// <param name="predicate">条件表达式树</param>
        /// <param name="field">字段</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns></returns>
        public float GetSum(Expression<Func<T, bool>> predicate, Expression<Func<T, float>> field,
            bool blUseNoLock = false)
        {
            return blUseNoLock
                ? DbBaseClient.Queryable<T>().Where(predicate).With(SqlWith.NoLock).Sum(field)
                : DbBaseClient.Queryable<T>().Where(predicate).Sum(field);
        }

        /// <summary>
        ///     获取数据某个字段的合计
        /// </summary>
        /// <param name="predicate">条件表达式树</param>
        /// <param name="field">字段</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns></returns>
        public async Task<float> GetSumAsync(Expression<Func<T, bool>> predicate, Expression<Func<T, float>> field,
            bool blUseNoLock = false)
        {
            return blUseNoLock
                ? await DbBaseClient.Queryable<T>().Where(predicate).With(SqlWith.NoLock).SumAsync(field)
                : await DbBaseClient.Queryable<T>().Where(predicate).SumAsync(field);
        }

        /// <summary>
        /// 写入实体数据
        /// </summary>
        /// <param name="entity">实体数据</param>
        /// <returns></returns>
        public int Insert(T entity)
        {
            return DbBaseClient.Insertable<T>(entity).ExecuteReturnIdentity();
        }

        /// <summary>
        /// 写入实体数据
        /// </summary>
        /// <param name="entity">实体数据</param>
        /// <returns></returns>
        public async Task<int> InsertAsync(T entity)
        {
            return await DbBaseClient.Insertable(entity).ExecuteReturnIdentityAsync();
        }

        /// <summary>
        /// 写入实体数据
        /// </summary>
        /// <param name="entity">实体数据</param>
        /// <param name="insertColumns">插入的列</param>
        /// <returns></returns>
        public int Insert(T entity, Expression<Func<T, object>> insertColumns = null)
        {
            var insert = DbBaseClient.Insertable<T>(entity);
            if (insertColumns != null)
                return insert.InsertColumns(insertColumns).ExecuteReturnIdentity();
            else
                return insert.ExecuteReturnIdentity();
        }

        /// <summary>
        /// 写入实体数据
        /// </summary>
        /// <param name="entity">实体数据</param>
        /// <param name="insertColumns">插入的列</param>
        /// <returns></returns>
        public async Task<int> InsertAsync(T entity, Expression<Func<T, object>> insertColumns = null)
        {
            var insert = DbBaseClient.Insertable<T>(entity);
            if (insertColumns != null)
                return await insert.InsertColumns(insertColumns).ExecuteReturnIdentityAsync();
            else
                return await insert.ExecuteReturnIdentityAsync();
        }

        /// <summary>
        /// 批量写入实体数据
        /// </summary>
        /// <param name="entity">实体类</param>
        /// <returns></returns>

        public int Insert(List<T> entity)
        {
            return DbBaseClient.Insertable(entity.ToArray()).ExecuteReturnIdentity();
        }

        /// <summary>
        /// 批量写入实体数据
        /// </summary>
        /// <param name="entity">实体类</param>
        /// <returns></returns>
        public async Task<int> InsertAsync(List<T> entity)
        {
            return await DbBaseClient.Insertable<T>(entity.ToArray()).ExecuteReturnIdentityAsync();
        }

        /// <summary>
        /// 写入实体数据
        /// </summary>
        /// <param name="entity">实体类</param>
        /// <param name="insertColumns">需插入的字段</param>
        /// <returns></returns>
        public bool InsertGuid(T entity, Expression<Func<T, object>> insertColumns = null)
        {
            var insert = DbBaseClient.Insertable<T>(entity);
            if (insertColumns == null)
                return insert.ExecuteCommand() > 0;
            else
                return insert.InsertColumns(insertColumns).ExecuteCommand() > 0;
        }

        /// <summary>
        /// 写入实体数据
        /// </summary>
        /// <param name="entity">实体类</param>
        /// <param name="insertColumns">需插入的字段</param>
        /// <returns></returns>
        public async Task<bool> InsertGuidAsync(T entity, Expression<Func<T, object>> insertColumns = null)
        {
            var insert = DbBaseClient.Insertable<T>(entity);
            if (insertColumns == null)
                return await insert.ExecuteCommandAsync() > 0;
            else
                return await insert.InsertColumns(insertColumns).ExecuteCommandAsync() > 0;
        }

        /// <summary>
        /// 查询表单所有数据(无分页,请慎用)
        /// </summary>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns></returns>
        public List<T> Query(bool blUseNoLock = false)
        {
            return blUseNoLock
              ? DbBaseClient.Queryable<T>().With(SqlWith.NoLock).ToList()
              : DbBaseClient.Queryable<T>().ToList();
        }

        /// <summary>
        /// 查询表单所有数据(无分页,请慎用)
        /// </summary>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns></returns>
        public async Task<List<T>> QueryAsync(bool blUseNoLock = false)
        {
            return blUseNoLock
              ? await DbBaseClient.Queryable<T>().With(SqlWith.NoLock).ToListAsync()
              : await DbBaseClient.Queryable<T>().ToListAsync();
        }

        /// <summary>
        /// 根据条件查询数据
        /// </summary>
        /// <param name="predicate">条件表达式树</param>
        /// <param name="orderByPredicate">排序字段</param>
        /// <param name="orderByType">排序顺序</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns></returns>
        public T QueryByClause(Expression<Func<T, bool>> predicate, Expression<Func<T, object>> orderByPredicate
            , OrderByType orderByType, bool blUseNoLock = false)
        {
            return blUseNoLock
                ? DbBaseClient.Queryable<T>().With(SqlWith.NoLock).WhereIF(predicate != null, predicate).OrderByIF(orderByPredicate != null, orderByPredicate, orderByType).First()
                : DbBaseClient.Queryable<T>().WhereIF(predicate != null, predicate).OrderByIF(orderByPredicate != null, orderByPredicate, orderByType).First();
        }

        /// <summary>
        /// 根据条件查询数据
        /// </summary>
        /// <param name="predicate">条件表达式树</param>
        /// <param name="orderByPredicate">排序字段</param>
        /// <param name="orderByType">排序顺序</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns></returns>
        public async Task<T> QueryByClauseAsync(Expression<Func<T, bool>> predicate, Expression<Func<T, object>> orderByPredicate, OrderByType orderByType, bool blUseNoLock = false)
        {
            return blUseNoLock
                ? await DbBaseClient.Queryable<T>().With(SqlWith.NoLock).WhereIF(predicate != null, predicate).OrderByIF(orderByPredicate != null, orderByPredicate, orderByType).FirstAsync()
                : await DbBaseClient.Queryable<T>().WhereIF(predicate != null, predicate).OrderByIF(orderByPredicate != null, orderByPredicate, orderByType).FirstAsync();
        }

        /// <summary>
        /// 根据主值查询单条数据
        /// </summary>
        /// <param name="pkValue">主键值</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns>泛型实体</returns>
        public T QueryById(object pkValue, bool blUseNoLock = false)
        {
            return blUseNoLock
              ? DbBaseClient.Queryable<T>().With(SqlWith.NoLock).InSingle(pkValue)
              : DbBaseClient.Queryable<T>().InSingle(pkValue);
        }

        /// <summary>
        /// 根据主值查询单条数据
        /// </summary>
        /// <param name="objId">id（必须指定主键特性 [SugarColumn(IsPrimaryKey=true)]），如果是联合主键，请使用Where条件</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns>数据实体</returns>
        public async Task<T> QueryByIdAsync(object objId, bool blUseNoLock = false)
        {
            return blUseNoLock
              ? await DbBaseClient.Queryable<T>().Where(SqlWith.NoLock).InSingleAsync(objId)
              : await DbBaseClient.Queryable<T>().InSingleAsync(objId);
        }

        /// <summary>
        /// 根据主值列表查询单条数据
        /// </summary>
        /// <param name="lstIds">id列表（必须指定主键特性 [SugarColumn(IsPrimaryKey=true)]），如果是联合主键，请使用Where条件</param>
        /// <returns>数据实体列表</returns>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        public List<T> QueryByIDs(object[] lstIds, bool blUseNoLock = false)
        {
            return blUseNoLock
              ? DbBaseClient.Queryable<T>().In(lstIds).With(SqlWith.NoLock).ToList()
              : DbBaseClient.Queryable<T>().In(lstIds).ToList();
        }

        /// <summary>
        /// 根据主值列表查询单条数据
        /// </summary>
        /// <param name="lstIds">id列表（必须指定主键特性 [SugarColumn(IsPrimaryKey=true)]），如果是联合主键，请使用Where条件</param>
        /// <returns>数据实体列表</returns>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        public async Task<List<T>> QueryByIDsAsync(object[] lstIds, bool blUseNoLock = false)
        {
            return blUseNoLock
              ? await DbBaseClient.Queryable<T>().With(SqlWith.NoLock).In(lstIds).ToListAsync()
              : await DbBaseClient.Queryable<T>().In(lstIds).ToListAsync();
        }

        /// <summary>
        /// 根据条件查询数据
        /// </summary>
        /// <param name="strWhere">条件</param>
        /// <param name="orderBy">排序字段，如name asc,age desc</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns>泛型实体集合</returns>
        public List<T> QueryListByClause(string strWhere, string orderBy = "", bool blUseNoLock = false)
        {
            return blUseNoLock
              ? DbBaseClient.Queryable<T>().With(SqlWith.NoLock).WhereIF(!string.IsNullOrEmpty(strWhere), strWhere).OrderByIF(!string.IsNullOrEmpty(orderBy), orderBy).ToList()
              : DbBaseClient.Queryable<T>().WhereIF(!string.IsNullOrEmpty(strWhere), strWhere).OrderByIF(!string.IsNullOrEmpty(orderBy), orderBy).ToList();
        }

        /// <summary>
        /// 根据条件查询数据
        /// </summary>
        /// <param name="strWhere">条件</param>
        /// <param name="orderBy">排序字段，如name asc,age desc</param>
        /// <returns>泛型实体集合</returns>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        public async Task<List<T>> QueryListByClauseAsync(string strWhere, string orderBy = "", bool blUseNoLock = false)
        {
            return blUseNoLock
              ? await DbBaseClient.Queryable<T>().With(SqlWith.NoLock).WhereIF(!string.IsNullOrEmpty(strWhere), strWhere).OrderByIF(!string.IsNullOrEmpty(orderBy), orderBy).ToListAsync()
              : await DbBaseClient.Queryable<T>().WhereIF(!string.IsNullOrEmpty(strWhere), strWhere).OrderByIF(!string.IsNullOrEmpty(orderBy), orderBy).ToListAsync();
        }

        /// <summary>
        /// 根据条件查询数据
        /// </summary>
        /// <param name="predicate">条件表达式树</param>
        /// <param name="orderBy">排序字段，如name asc,age desc</param>
        /// <returns>泛型实体集合</returns>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        public List<T> QueryListByClause(Expression<Func<T, bool>> predicate, string orderBy = "", bool blUseNoLock = false)
        {
            return blUseNoLock
              ? DbBaseClient.Queryable<T>().With(SqlWith.NoLock).WhereIF(predicate != null, predicate).OrderByIF(!string.IsNullOrEmpty(orderBy), orderBy).ToList()
              : DbBaseClient.Queryable<T>().WhereIF(predicate != null, predicate).OrderByIF(!string.IsNullOrEmpty(orderBy), orderBy).ToList();
        }

        /// <summary>
        /// 根据条件查询数据
        /// </summary>
        /// <param name="predicate">条件表达式树</param>
        /// <param name="orderBy">排序字段，如name asc,age desc</param>
        /// <returns>泛型实体集合</returns>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        public async Task<List<T>> QueryListByClauseAsync(Expression<Func<T, bool>> predicate, string orderBy = "", bool blUseNoLock = false)
        {
            return blUseNoLock
              ? await DbBaseClient.Queryable<T>().With(SqlWith.NoLock).WhereIF(predicate != null, predicate).OrderByIF(!string.IsNullOrEmpty(orderBy), orderBy).ToListAsync()
              : await DbBaseClient.Queryable<T>().WhereIF(predicate != null, predicate).OrderByIF(!string.IsNullOrEmpty(orderBy), orderBy).ToListAsync();
        }

        /// <summary>
        /// 根据条件查询数据
        /// </summary>
        /// <param name="predicate">条件表达式树</param>
        /// <param name="orderByPredicate">排序字段</param>
        /// <param name="orderByType">排序顺序</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns>泛型实体集合</returns>
        public List<T> QueryListByClause(Expression<Func<T, bool>> predicate,
          Expression<Func<T, object>> orderByPredicate, OrderByType orderByType, bool blUseNoLock = false)
        {
            return blUseNoLock
              ? DbBaseClient.Queryable<T>().With(SqlWith.NoLock).WhereIF(predicate != null, predicate)
              .OrderByIF(orderByPredicate != null, orderByPredicate, orderByType).ToList()
              : DbBaseClient.Queryable<T>().WhereIF(predicate != null, predicate)
              .OrderByIF(orderByPredicate != null, orderByPredicate, orderByType).ToList();
        }

        /// <summary>
        /// 根据条件查询数据
        /// </summary>
        /// <param name="predicate">条件表达式树</param>
        /// <param name="orderByPredicate">排序字段</param>
        /// <param name="orderByType">排序顺序</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns>泛型实体集合</returns>
        public async Task<List<T>> QueryListByClauseAsync(Expression<Func<T, bool>> predicate,
          Expression<Func<T, object>> orderByPredicate, OrderByType orderByType, bool blUseNoLock = false)
        {
            return blUseNoLock
              ? await DbBaseClient.Queryable<T>().With(SqlWith.NoLock).WhereIF(predicate != null, predicate)
              .OrderByIF(orderByPredicate != null, orderByPredicate, orderByType).ToListAsync()
              : await DbBaseClient.Queryable<T>().WhereIF(predicate != null, predicate)
              .OrderByIF(orderByPredicate != null, orderByPredicate, orderByType).ToListAsync();
        }

        /// <summary>
        /// 根据条件查询一定数量数据
        /// </summary>
        /// <param name="predicate">条件表达式树</param>
        /// <param name="take">获取数量</param>
        /// <param name="orderPredicate">排序字段</param>
        /// <param name="orderByType">排序顺序</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns></returns>
        public List<T> QueryListByClause(Expression<Func<T, bool>> predicate, int take,
          Expression<Func<T, object>> orderPredicate, OrderByType orderByType, bool blUseNoLock = false)
        {
            return blUseNoLock
              ? DbBaseClient.Queryable<T>().With(SqlWith.NoLock).WhereIF(predicate != null, predicate).
              Take(take).OrderByIF(orderPredicate != null, orderPredicate, orderByType).ToList()
              : DbBaseClient.Queryable<T>().With(SqlWith.NoLock).WhereIF(predicate != null, predicate).
              Take(take).OrderByIF(orderPredicate != null, orderPredicate, orderByType).ToList();
        }

        /// <summary>
        /// 根据条件查询一定数量数据
        /// </summary>
        /// <param name="predicate">条件表达式树</param>
        /// <param name="take">获取数量</param>
        /// <param name="orderPredicate">排序字段</param>
        /// <param name="orderByType">排序顺序</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns></returns>
        public async Task<List<T>> QueryListByClauseAsync(Expression<Func<T, bool>> predicate, int take, Expression<Func<T, object>> orderPredicate, OrderByType orderByType, bool blUseNoLock = false)
        {
            return blUseNoLock
              ? await DbBaseClient.Queryable<T>().With(SqlWith.NoLock).WhereIF(predicate != null, predicate).
              Take(take).OrderByIF(orderPredicate != null, orderPredicate, orderByType).ToListAsync()
              : await DbBaseClient.Queryable<T>().With(SqlWith.NoLock).WhereIF(predicate != null, predicate).
              Take(take).OrderByIF(orderPredicate != null, orderPredicate, orderByType).ToListAsync();
        }

        /// <summary>
        /// 根据条件查询一定数量数据
        /// </summary>
        /// <param name="predicate">条件表达式树</param>
        /// <param name="take">获取数量</param>
        /// <param name="strOrderByFileds">排序字段，如name asc,age desc</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns></returns>
        public List<T> QueryListByClause(Expression<Func<T, bool>> predicate, int take, string strOrderByFileds = "", bool blUseNoLock = false)
        {
            return blUseNoLock
                      ? DbBaseClient.Queryable<T>().OrderByIF(!string.IsNullOrEmpty(strOrderByFileds), strOrderByFileds)
                          .Where(predicate).Take(take).With(SqlWith.NoLock).ToList()
                      : DbBaseClient.Queryable<T>().OrderByIF(!string.IsNullOrEmpty(strOrderByFileds), strOrderByFileds)
                          .Where(predicate).Take(take).ToList();
        }

        /// <summary>
        /// 根据条件查询一定数量数据
        /// </summary>
        /// <param name="predicate">条件表达式树</param>
        /// <param name="take">获取数量</param>
        /// <param name="strOrderByFileds">排序字段，如name asc,age desc</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns></returns>
        public async Task<List<T>> QueryListByClauseAsync(Expression<Func<T, bool>> predicate, int take, string strOrderByFileds = "", bool blUseNoLock = false)
        {
            return blUseNoLock
                      ? await DbBaseClient.Queryable<T>().OrderByIF(!string.IsNullOrEmpty(strOrderByFileds), strOrderByFileds)
                          .Where(predicate).Take(take).With(SqlWith.NoLock).ToListAsync()
                      : await DbBaseClient.Queryable<T>().OrderByIF(!string.IsNullOrEmpty(strOrderByFileds), strOrderByFileds)
                          .Where(predicate).Take(take).ToListAsync();
        }

        public List<TResult> QueryMuch<T1, T2, TResult>(Expression<Func<T1, T2, object[]>> joinExpression, Expression<Func<T1, T2, TResult>> selectExpression, Expression<Func<T1, T2, bool>> whereLambda = null, bool blUseNoLock = false) where T1 : class, new()
        {
            if (whereLambda == null)
                return blUseNoLock
                    ? DbBaseClient.Queryable(joinExpression).Select(selectExpression).With(SqlWith.NoLock).ToList()
                    : DbBaseClient.Queryable(joinExpression).Select(selectExpression).ToList();
            else
                return blUseNoLock
                  ? DbBaseClient.Queryable(joinExpression).Where(whereLambda).Select(selectExpression).With(SqlWith.NoLock).ToList()
                  : DbBaseClient.Queryable(joinExpression).Where(whereLambda).Select(selectExpression).ToList();

        }

        /// <summary>
        ///  查询-三表查询
        /// </summary>
        /// <typeparam name="T">实体1</typeparam>
        /// <typeparam name="T2">实体2</typeparam>
        /// <typeparam name="T3">实体3</typeparam>
        /// <typeparam name="TResult">返回对象</typeparam>
        /// <param name="joinExpression">关联表达式 (join1,join2) => new object[] {JoinType.Left,join1.UserNo==join2.UserNo}</param>
        /// <param name="selectExpression">返回表达式 (s1, s2) => new { Id =s1.UserNo, Id1 = s2.UserNo}</param>
        /// <param name="whereLambda">查询表达式 (w1, w2) =>w1.UserNo == "")</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns>值</returns>
        public List<TResult> QueryMuch<T1, T2, T3, TResult>(Expression<Func<T1, T2, T3, object[]>> joinExpression
            , Expression<Func<T1, T2, T3, TResult>> selectExpression
            , Expression<Func<T1, T2, T3, bool>> whereLambda = null
            , bool blUseNoLock = false) where T1 : class, new()
        {
            if (whereLambda == null)
                return blUseNoLock
                    ? DbBaseClient.Queryable(joinExpression).Select(selectExpression).With(SqlWith.NoLock)
                        .ToList()
                    : DbBaseClient.Queryable(joinExpression).Select(selectExpression).ToList();
            return blUseNoLock
                ? DbBaseClient.Queryable(joinExpression).Where(whereLambda).Select(selectExpression).With(SqlWith.NoLock)
                    .ToList()
                : DbBaseClient.Queryable(joinExpression).Where(whereLambda).Select(selectExpression)
                    .ToList();
        }

        /// <summary>
        ///  查询-三表查询
        /// </summary>
        /// <typeparam name="T">实体1</typeparam>
        /// <typeparam name="T2">实体2</typeparam>
        /// <typeparam name="T3">实体3</typeparam>
        /// <typeparam name="TResult">返回对象</typeparam>
        /// <param name="joinExpression">关联表达式 (join1,join2) => new object[] {JoinType.Left,join1.UserNo==join2.UserNo}</param>
        /// <param name="selectExpression">返回表达式 (s1, s2) => new { Id =s1.UserNo, Id1 = s2.UserNo}</param>
        /// <param name="whereLambda">查询表达式 (w1, w2) =>w1.UserNo == "")</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns>值</returns>
        public async Task<List<TResult>> QueryMuchAsync<T1, T2, T3, TResult>(Expression<Func<T1, T2, T3, object[]>> joinExpression, Expression<Func<T1, T2, T3, TResult>> selectExpression, Expression<Func<T1, T2, T3, bool>> whereLambda = null, bool blUseNoLock = false) where T1 : class, new()
        {
            if (whereLambda == null)
                return blUseNoLock
                    ? await DbBaseClient.Queryable(joinExpression).Select(selectExpression).With(SqlWith.NoLock)
                        .ToListAsync()
                    : await DbBaseClient.Queryable(joinExpression).Select(selectExpression).ToListAsync();
            return blUseNoLock
                ? await DbBaseClient.Queryable(joinExpression).Where(whereLambda).Select(selectExpression)
                    .With(SqlWith.NoLock)
                    .ToListAsync()
                : await DbBaseClient.Queryable(joinExpression).Where(whereLambda).Select(selectExpression)
                    .ToListAsync();
        }

        /// <summary>
        /// 查询-二表查询
        /// </summary>
        /// <typeparam name="T1">实体1</typeparam>
        /// <typeparam name="T2">实体2</typeparam>
        /// <typeparam name="TResult">返回对象</typeparam>
        /// <param name="joinExpression">关联表达式 (join1,join2) => new object[] {JoinType.Left,join1.UserNo==join2.UserNo}</param>
        /// <param name="selectExpression">返回表达式 (s1, s2) => new { Id =s1.UserNo, Id1 = s2.UserNo}</param>
        /// <param name="whereLambda">查询表达式 (w1, w2) =>w1.UserNo == "")</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns>值</returns>
        public TResult QueryMuchFirst<T1, T2, TResult>(Expression<Func<T1, T2, object[]>> joinExpression, Expression<Func<T1, T2, TResult>> selectExpression, Expression<Func<T1, T2, bool>> whereLambda = null, bool blUseNoLock = false) where T1 : class, new()
        {
            if (whereLambda == null)
                return blUseNoLock
                    ? DbBaseClient.Queryable(joinExpression).Select(selectExpression).With(SqlWith.NoLock).First()
                    : DbBaseClient.Queryable(joinExpression).Select(selectExpression).First();
            return blUseNoLock
                ? DbBaseClient.Queryable(joinExpression).Where(whereLambda).Select(selectExpression).With(SqlWith.NoLock)
                    .First()
                : DbBaseClient.Queryable(joinExpression).Where(whereLambda).Select(selectExpression).First();
        }

        /// <summary>
        /// 查询-二表查询
        /// </summary>
        /// <typeparam name="T1">实体1</typeparam>
        /// <typeparam name="T2">实体2</typeparam>
        /// <typeparam name="TResult">返回对象</typeparam>
        /// <param name="joinExpression">关联表达式 (join1,join2) => new object[] {JoinType.Left,join1.UserNo==join2.UserNo}</param>
        /// <param name="selectExpression">返回表达式 (s1, s2) => new { Id =s1.UserNo, Id1 = s2.UserNo}</param>
        /// <param name="whereLambda">查询表达式 (w1, w2) =>w1.UserNo == "")</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns>值</returns>
        public Task<TResult> QueryMuchFirstAsync<T1, T2, TResult>(Expression<Func<T1, T2, object[]>> joinExpression, Expression<Func<T1, T2, TResult>> selectExpression, Expression<Func<T1, T2, bool>> whereLambda = null, bool blUseNoLock = false) where T1 : class, new()
        {
            var query = DbBaseClient.Queryable(joinExpression);
            if (whereLambda == null)
                return blUseNoLock
                    ? query.Select(selectExpression).With(SqlWith.NoLock).FirstAsync()
                    : query.Select(selectExpression).FirstAsync();
            else
                return blUseNoLock 
                    ? query.Where(whereLambda).Select(selectExpression).With(SqlWith.NoLock).FirstAsync()
                    : query.Where(whereLambda).Select(selectExpression).FirstAsync();
        }

        /// <summary>
        /// 根据条件查询分页数据
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="orderBy"></param>
        /// <param name="pageIndex">当前页面索引</param>
        /// <param name="pageSize">分布大小</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns></returns>
        public IPageList<T> QueryPage(Expression<Func<T, bool>> predicate, string orderBy = "", int pageIndex = 1, int pageSize = 20, bool blUseNoLock = false)
        {
            var totalCount = 0;
            var page = blUseNoLock
              ? DbBaseClient.Queryable<T>().WhereIF(predicate != null, predicate).OrderByIF(!string.IsNullOrEmpty(orderBy), orderBy)
              .With(SqlWith.NoLock).ToPageList(pageIndex, pageSize, ref totalCount)
              : DbBaseClient.Queryable<T>().WhereIF(predicate != null, predicate).OrderByIF(!string.IsNullOrEmpty(orderBy), orderBy)
              .ToPageList(pageIndex, pageSize, ref totalCount);
            return new PageList<T>(page, pageIndex, pageSize, totalCount);
        }

        /// <summary>
        /// 根据条件查询分页数据
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="orderBy"></param>
        /// <param name="pageIndex">当前页面索引</param>
        /// <param name="pageSize">分布大小</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns></returns>
        public async Task<IPageList<T>> QueryPageAsync(Expression<Func<T, bool>> predicate, string orderBy = "", int pageIndex = 1, int pageSize = 20, bool blUseNoLock = false)
        {
            RefAsync<int> totalCount = 0;
            var page = blUseNoLock
              ? await DbBaseClient.Queryable<T>().WhereIF(predicate != null, predicate).OrderByIF(!string.IsNullOrEmpty(orderBy), orderBy)
              .With(SqlWith.NoLock).ToPageListAsync(pageIndex, pageSize, totalCount)
              : await DbBaseClient.Queryable<T>().WhereIF(predicate != null, predicate).OrderByIF(!string.IsNullOrEmpty(orderBy), orderBy)
              .ToPageListAsync(pageIndex, pageSize, totalCount);
            return new PageList<T>(page, pageIndex, pageSize, totalCount);
        }

        /// <summary>
        /// 根据条件查询分页数据
        /// </summary>
        /// <param name="predicate">判断集合</param>
        /// <param name="orderByType">排序方式</param>
        /// <param name="pageIndex">当前页面索引</param>
        /// <param name="pageSize">分布大小</param>
        /// <param name="orderByExpression"></param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns></returns>
        public IPageList<T> QueryPage(Expression<Func<T, bool>> predicate, Expression<Func<T, object>> orderByExpression, OrderByType orderByType, int pageIndex = 1, int pageSize = 20, bool blUseNoLock = false)
        {
            var totalCount = 0;
            var page = blUseNoLock
                ? DbBaseClient.Queryable<T>().OrderByIF(orderByExpression != null, orderByExpression, orderByType)
                    .WhereIF(predicate != null, predicate).Where(SqlWith.NoLock)
                    .ToPageList(pageIndex, pageSize, ref totalCount)
                : DbBaseClient.Queryable<T>().OrderByIF(orderByExpression != null, orderByExpression, orderByType)
                    .WhereIF(predicate != null, predicate).ToPageList(pageIndex, pageSize, ref totalCount);
            var list = new PageList<T>(page, pageIndex, pageSize, totalCount);
            return list;
        }

        /// <summary>
        /// 根据条件查询分页数据
        /// </summary>
        /// <param name="predicate">判断集合</param>
        /// <param name="orderByType">排序方式</param>
        /// <param name="pageIndex">当前页面索引</param>
        /// <param name="pageSize">分布大小</param>
        /// <param name="orderByExpression"></param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns></returns>
        public async Task<IPageList<T>> QueryPageAsync(Expression<Func<T, bool>> predicate, Expression<Func<T, object>> orderByExpression, OrderByType orderByType, int pageIndex = 1, int pageSize = 20, bool blUseNoLock = false)
        {
            RefAsync<int> totalCount = 0;
            var page = blUseNoLock
                ? await DbBaseClient.Queryable<T>().WhereIF(predicate != null, predicate).OrderByIF(orderByExpression != null, orderByExpression, orderByType)
                    .Where(SqlWith.NoLock).ToPageListAsync(pageIndex, pageSize, totalCount)
                : await DbBaseClient.Queryable<T>().WhereIF(predicate != null, predicate).OrderByIF(orderByExpression != null, orderByExpression, orderByType)
                    .ToPageListAsync(pageIndex, pageSize, totalCount);
            var list = new PageList<T>(page, pageIndex, pageSize, totalCount);
            return list;
        }

        /// <summary>
        /// 根据条件查询数据
        /// </summary>
        /// <param name="predicate">条件表达式树</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns></returns>
        public T QueryByClause(Expression<Func<T, bool>> predicate, bool blUseNoLock = false)
        {
            return blUseNoLock
              ? DbBaseClient.Queryable<T>().With(SqlWith.NoLock).WhereIF(predicate != null, predicate).First()
              : DbBaseClient.Queryable<T>().WhereIF(predicate != null, predicate).First();
        }

        /// <summary>
        /// 根据条件查询数据
        /// </summary>
        /// <param name="predicate">条件表达式树</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns></returns>
        public async Task<T> QuseryByClauseAsync(Expression<Func<T, bool>> predicate, bool blUseNoLock = false)
        {
            return blUseNoLock
              ? await DbBaseClient.Queryable<T>().With(SqlWith.NoLock).WhereIF(predicate != null, predicate).FirstAsync()
              : await DbBaseClient.Queryable<T>().WhereIF(predicate != null, predicate).FirstAsync();
        }

        /// <summary>
        /// 执行sql语句并返回List<T>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public List<T> SqlQuery(string sql, List<SugarParameter> parameters)
        {
            return DbBaseClient.Ado.SqlQuery<T>(sql, parameters);
        }

        /// <summary>
        /// 执行sql语句并返回List<T>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public async Task<List<T>> SqlQueryable(string sql)
        {
            return await DbBaseClient.Ado.SqlQueryAsync<T>(sql);
            //var list = await DbBaseClient.SqlQueryable<T>(sql).ToListAsync();
            //return list;
        }

        /// <summary>
        /// 批量更新实体数据
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Update(List<T> entity)
        {
            return DbBaseClient.Updateable<T>(entity).ExecuteCommandHasChange();
        }

        /// <summary>
        /// 批量更新实体数据
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<bool> UpdateAsync(List<T> entity)
        {
            return await DbBaseClient.Updateable<T>(entity).ExecuteCommandHasChangeAsync();
        }

        /// <summary>
        /// 更新实体数据
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        public bool Update(T entity)
        {
            return DbBaseClient.Updateable<T>(entity).ExecuteCommandHasChange();
        }

        /// <summary>
        /// 更新实体数据
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        public async Task<bool> UpdateAsync(T entity)
        {
            return await DbBaseClient.Updateable<T>(entity).ExecuteCommandHasChangeAsync();
        }

        /// <summary>
        /// 根据手写条件更新
        /// </summary>
        /// <param name="entity">实体</param>
        /// <param name="strWhere">条件</param>
        /// <returns></returns>
        public bool Update(T entity, string strWhere)
        {
            return DbBaseClient.Updateable<T>(entity).Where(strWhere).ExecuteCommandHasChange();
        }

        /// <summary>
        /// 根据手写条件更新
        /// </summary>
        /// <param name="entity">实体</param>
        /// <param name="strWhere">条件</param>
        /// <returns></returns>
        public async Task<bool> UpdateAsync(T entity, string strWhere)
        {
            return await DbBaseClient.Updateable<T>(entity).Where(strWhere).ExecuteCommandHasChangeAsync();
        }

        /// <summary>
        /// 根据手写sql语句更新数据
        /// </summary>
        /// <param name="strSql">sql语句</param>
        /// <param name="parameters">参数</param>
        /// <returns></returns>
        public bool Update(string strSql, SugarParameter[] parameters = null)
        {
            return DbBaseClient.Ado.ExecuteCommand(strSql, parameters) > 0;
        }

        /// <summary>
        /// 根据手写sql语句更新数据
        /// </summary>
        /// <param name="strSql">sql语句</param>
        /// <param name="parameters">参数</param>
        /// <returns></returns>
        public async Task<bool> UpdateAsync(string strSql, SugarParameter[] parameters = null)
        {
            return await DbBaseClient.Ado.ExecuteCommandAsync(strSql, parameters) > 0;
        }

        /// <summary>
        /// 更新某个字段
        /// </summary>
        /// <param name="columns">lamdba表达式,如it => new Student() { Name = "a", CreateTime = DateTime.Now }</param>
        /// <param name="where">lamdba判断</param>
        /// <returns></returns>
        public bool Update(Expression<Func<T, T>> columns, Expression<Func<T, bool>> where)
        {
            return DbBaseClient.Updateable<T>().SetColumns(columns).Where(where).ExecuteCommandHasChange();
            //var i = DbBaseClient.Updateable<T>().SetColumns(columns).Where(where).ExecuteCommand();
            //return i > 0;
        }

        /// <summary>
        /// 更新某个字段
        /// </summary>
        /// <param name="columns">lamdba表达式,如it => new Student() { Name = "a", CreateTime = DateTime.Now }</param>
        /// <param name="where">lamdba判断</param>
        /// <returns></returns>
        public async Task<bool> UpdateAsync(Expression<Func<T, T>> columns, Expression<Func<T, bool>> where)
        {
            return await DbBaseClient.Updateable<T>().SetColumns(columns).Where(where).ExecuteCommandHasChangeAsync();
            //return await DbBaseClient.Updateable<T>().SetColumns(columns).Where(where).ExecuteCommand() > 0;
        }

        /// <summary>
        /// 根据条件更新
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="lstColumns"></param>
        /// <param name="lstIgnoreColumns"></param>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public bool Update(T entity, List<string> lstColumns = null, List<string> lstIgnoreColumns = null, string strWhere = "")
        {
            var up = DbBaseClient.Updateable<T>(entity);
            if (lstColumns != null && lstColumns.Count > 0) up = up.UpdateColumns(lstColumns.ToArray());
            if (lstIgnoreColumns != null && lstIgnoreColumns.Count > 0) up = up.UpdateColumns(lstIgnoreColumns.ToArray());
            if (!string.IsNullOrEmpty(strWhere)) up = up.Where(strWhere);
            return up.ExecuteCommandHasChange();
        }

        /// <summary>
        /// 根据条件更新
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="lstcolumn"></param>
        /// <param name="lstIngoreColumns"></param>
        /// <returns></returns>
        public async Task<bool> UpdateAsync(T entity, List<string> lstcolumn = null, List<string> lstIngoreColumns = null)
        {
            var up = DbBaseClient.Updateable<T>(entity);
            if (lstcolumn != null && lstcolumn.Count > 0) up = up.UpdateColumns(lstcolumn.ToArray());
            if (lstIngoreColumns != null && lstIngoreColumns.Count > 0) up = up.UpdateColumns(lstIngoreColumns.ToArray());

            return await up.ExecuteCommandHasChangeAsync();
        }

        /// <summary>
        /// 根据条件更新
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="lstColumns"></param>
        /// <param name="lstIgnoreColumns"></param>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public async Task<bool> UpdateAsync(T entity, List<string> lstColumns = null, List<string> lstIgnoreColumns = null, string strWhere = "")
        {
            var up = DbBaseClient.Updateable<T>(entity);
            if (lstColumns != null && lstColumns.Count > 0) up = up.UpdateColumns(lstColumns.ToArray());
            if (lstIgnoreColumns != null && lstIgnoreColumns.Count > 0) up = up.UpdateColumns(lstIgnoreColumns.ToArray());
            if (!string.IsNullOrEmpty(strWhere)) up = up.Where(strWhere);
            return await up.ExecuteCommandHasChangeAsync();
        }

        /// <summary>
        /// 根据条件查询实体
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="blUseNoLock"></param>
        /// <returns></returns>
        public T QuseryByClause(Expression<Func<T, bool>> predicate, bool blUseNoLock = false)
        {
            return blUseNoLock
              ? DbBaseClient.Queryable<T>().With(SqlWith.NoLock).WhereIF(predicate != null, predicate).First()
              : DbBaseClient.Queryable<T>().WhereIF(predicate != null, predicate).First();
        }

        public T QueryById(int pkValue, bool blUseNoLock = false)
        {
            throw new NotImplementedException();
        }

        public Task<T> QueryByIdAsync(int objId, bool blUseNoLock = false)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     根据主值列表查询单条数据
        /// </summary>
        /// <param name="lstIds">id列表（必须指定主键特性 [SugarColumn(IsPrimaryKey=true)]），如果是联合主键，请使用Where条件</param>
        /// <returns>数据实体列表</returns>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        public List<T> QueryByIDs(int[] lstIds, bool blUseNoLock = false)
        {
            return blUseNoLock
                ? DbBaseClient.Queryable<T>().In(lstIds).With(SqlWith.NoLock).ToList()
                : DbBaseClient.Queryable<T>().In(lstIds).ToList();
        }

        /// <summary>
        /// 根据主值列表查询单条数据
        /// </summary>
        /// <param name="lstIds">id列表（必须指定主键特性 [SugarColumn(IsPrimaryKey=true)]），如果是联合主键，请使用Where条件</param>
        /// <returns>数据实体列表</returns>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        public async Task<List<T>> QueryByIDsAsync(int[] lstIds, bool blUseNoLock = false)
        {
            return blUseNoLock
                ? await DbBaseClient.Queryable<T>().In(lstIds).With(SqlWith.NoLock).ToListAsync()
                : await DbBaseClient.Queryable<T>().In(lstIds).ToListAsync();
        }

        /// <summary>
        /// 批量写入实体数据
        /// </summary>
        /// <param name="entity">实体类</param>
        /// <returns></returns>
        public async Task<int> InsertCommandAsync(List<T> entity)
        {
            return await DbBaseClient.Insertable(entity.ToArray()).ExecuteCommandAsync();
        }

        /// <summary>
        /// 根据条件查询数据
        /// </summary>
        /// <param name="predicate">条件表达式树</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns></returns>
        public async Task<T> QueryByClauseAsync(Expression<Func<T, bool>> predicate, bool blUseNoLock = false)
        {
            return blUseNoLock
                ? await DbBaseClient.Queryable<T>().With(SqlWith.NoLock).FirstAsync(predicate)
                : await DbBaseClient.Queryable<T>().FirstAsync(predicate);
        }

        /// <summary>
        /// 查询-多表查询
        /// </summary>
        /// <typeparam name="T1">实体1</typeparam>
        /// <typeparam name="T2">实体2</typeparam>
        /// <typeparam name="TResult">返回对象</typeparam>
        /// <param name="joinExpression">关联表达式 (join1,join2) => new object[] {JoinType.Left,join1.UserNo==join2.UserNo}</param>
        /// <param name="selectExpression">返回表达式 (s1, s2) => new { Id =s1.UserNo, Id1 = s2.UserNo}</param>
        /// <param name="whereLambda">查询表达式 (w1, w2) =>w1.UserNo == "")</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns>值</returns>
        public async Task<List<TResult>> QueryMuchAsync<T1, T2, TResult>(
            Expression<Func<T1, T2, object[]>> joinExpression,
            Expression<Func<T1, T2, TResult>> selectExpression,
            Expression<Func<T1, T2, bool>> whereLambda = null,
            bool blUseNoLock = false) where T1 : class, new()
        {
            if (whereLambda == null)
                return blUseNoLock
                    ? await DbBaseClient.Queryable(joinExpression).Select(selectExpression).With(SqlWith.NoLock)
                        .ToListAsync()
                    : await DbBaseClient.Queryable(joinExpression).Select(selectExpression).ToListAsync();
            return blUseNoLock
                ? await DbBaseClient.Queryable(joinExpression).Where(whereLambda).Select(selectExpression)
                    .With(SqlWith.NoLock).ToListAsync()
                : await DbBaseClient.Queryable(joinExpression).Where(whereLambda).Select(selectExpression).ToListAsync();
        }
    }
}
