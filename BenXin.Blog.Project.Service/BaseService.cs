using BenXin.Blog.Project.IRepository;
using BenXin.Blog.Project.IService;
using BenXin.Blog.Project.Model.ViewModel;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BenXin.Blog.Project.Service
{
    public class BaseService<T> : IBaseService<T> where T : class, new()
    {
        //子类的构造函数直接注入
        protected IBaseRepository<T> _baseRepository = null;

        /// <summary>
        ///     根据主值查询单条数据
        /// </summary>
        /// <param name="pkValue">主键值</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns>泛型实体</returns>
        public T QueryById(object pkValue, bool blUseNoLock = false)
        {
            return _baseRepository.QueryById(pkValue, blUseNoLock);
        }

        /// <summary>
        ///     根据主值查询单条数据
        /// </summary>
        /// <param name="objId">id（必须指定主键特性 [SugarColumn(IsPrimaryKey=true)]），如果是联合主键，请使用Where条件</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns>数据实体</returns>
        public async Task<T> QueryByIdAsync(object objId, bool blUseNoLock = false)
        {
            return await _baseRepository.QueryByIdAsync(objId, blUseNoLock);
        }

        /// <summary>
        ///     根据主值列表查询单条数据
        /// </summary>
        /// <param name="lstIds">id列表（必须指定主键特性 [SugarColumn(IsPrimaryKey=true)]），如果是联合主键，请使用Where条件</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns>数据实体列表</returns>
        public List<T> QueryByIDs(object[] lstIds, bool blUseNoLock = false)
        {
            return _baseRepository.QueryByIDs(lstIds, blUseNoLock);
        }

        /// <summary>
        ///     根据主值列表查询单条数据
        /// </summary>
        /// <param name="lstIds">id列表（必须指定主键特性 [SugarColumn(IsPrimaryKey=true)]），如果是联合主键，请使用Where条件</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns>数据实体列表</returns>
        public async Task<List<T>> QueryByIDsAsync(object[] lstIds, bool blUseNoLock = false)
        {
            return await _baseRepository.QueryByIDsAsync(lstIds, blUseNoLock);
        }

        /// <summary>
        /// 根据主值列表查询单条数据
        /// </summary>
        /// <param name="lstIds">id列表（必须指定主键特性 [SugarColumn(IsPrimaryKey=true)]），如果是联合主键，请使用Where条件</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns>数据实体列表</returns>
        public List<T> QueryByIDs(int[] lstIds, bool blUseNoLock = false)
        {
            return _baseRepository.QueryByIDs(lstIds, blUseNoLock);
        }

        /// <summary>
        /// 根据主值列表查询单条数据
        /// </summary>
        /// <param name="lstIds">id列表（必须指定主键特性 [SugarColumn(IsPrimaryKey=true)]），如果是联合主键，请使用Where条件</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns>数据实体列表</returns>
        public async Task<List<T>> QueryByIDsAsync(int[] lstIds, bool blUseNoLock = false)
        {
            return await _baseRepository.QueryByIDsAsync(lstIds, blUseNoLock);
        }

        /// <summary>
        ///     查询表单所有数据(无分页,请慎用)
        /// </summary>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns></returns>
        public List<T> Query(bool blUseNoLock = false)
        {
            var list = _baseRepository.Query(blUseNoLock);
            return list;
        }

        /// <summary>
        ///     查询表单所有数据(无分页,请慎用)
        /// </summary>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns></returns>
        public async Task<List<T>> QueryAsync(bool blUseNoLock = false)
        {
            return await _baseRepository.QueryAsync(blUseNoLock);
        }

        /// <summary>
        ///     根据条件查询数据
        /// </summary>
        /// <param name="strWhere">条件</param>
        /// <param name="orderBy">排序字段，如name asc,age desc</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns>泛型实体集合</returns>
        public List<T> QueryListByClause(string strWhere, string orderBy = "", bool blUseNoLock = false)
        {
            return _baseRepository.QueryListByClause(strWhere, orderBy, blUseNoLock);
        }

        /// <summary>
        ///     根据条件查询数据
        /// </summary>
        /// <param name="strWhere">条件</param>
        /// <param name="orderBy">排序字段，如name asc,age desc</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns>泛型实体集合</returns>
        public async Task<List<T>> QueryListByClauseAsync(string strWhere, string orderBy = "",
            bool blUseNoLock = false)
        {
            return await _baseRepository.QueryListByClauseAsync(strWhere, orderBy, blUseNoLock);
        }

        /// <summary>
        ///     根据条件查询数据
        /// </summary>
        /// <param name="predicate">条件表达式树</param>
        /// <param name="orderBy">排序字段，如name asc,age desc</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns>泛型实体集合</returns>
        public List<T> QueryListByClause(Expression<Func<T, bool>> predicate, string orderBy = "",
            bool blUseNoLock = false)
        {
            return _baseRepository.QueryListByClause(predicate, orderBy, blUseNoLock);
        }

        /// <summary>
        ///     根据条件查询数据
        /// </summary>
        /// <param name="predicate">条件表达式树</param>
        /// <param name="orderBy">排序字段，如name asc,age desc</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns>泛型实体集合</returns>
        public async Task<List<T>> QueryListByClauseAsync(Expression<Func<T, bool>> predicate, string orderBy = "",
            bool blUseNoLock = false)
        {
            return await _baseRepository.QueryListByClauseAsync(predicate, orderBy, blUseNoLock);
        }

        /// <summary>
        ///     根据条件查询数据
        /// </summary>
        /// <param name="predicate">条件表达式树</param>
        /// <param name="orderByPredicate">排序字段</param>
        /// <param name="orderByType">排序顺序</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns>泛型实体集合</returns>
        public List<T> QueryListByClause(Expression<Func<T, bool>> predicate,
            Expression<Func<T, object>> orderByPredicate, OrderByType orderByType, bool blUseNoLock = false)
        {
            return _baseRepository.QueryListByClause(predicate, orderByPredicate, orderByType, blUseNoLock);
        }

        /// <summary>
        ///     根据条件查询数据
        /// </summary>
        /// <param name="predicate">条件表达式树</param>
        /// <param name="orderByPredicate">排序字段</param>
        /// <param name="orderByType">排序顺序</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns>泛型实体集合</returns>
        public async Task<List<T>> QueryListByClauseAsync(Expression<Func<T, bool>> predicate,
            Expression<Func<T, object>> orderByPredicate, OrderByType orderByType, bool blUseNoLock = false)
        {
            return await _baseRepository.QueryListByClauseAsync(predicate, orderByPredicate, orderByType, blUseNoLock);
        }

        /// <summary>
        ///     根据条件查询一定数量数据
        /// </summary>
        /// <param name="predicate">条件表达式树</param>
        /// <param name="take">获取数量</param>
        /// <param name="orderByPredicate">排序字段</param>
        /// <param name="orderByType">排序顺序</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns></returns>
        public List<T> QueryListByClause(Expression<Func<T, bool>> predicate, int take,
            Expression<Func<T, object>> orderByPredicate, OrderByType orderByType, bool blUseNoLock = false)
        {
            return _baseRepository.QueryListByClause(predicate, take, orderByPredicate, orderByType, blUseNoLock);
        }

        /// <summary>
        ///     根据条件查询一定数量数据
        /// </summary>
        /// <param name="predicate">条件表达式树</param>
        /// <param name="take">获取数量</param>
        /// <param name="orderByPredicate">排序字段</param>
        /// <param name="orderByType">排序顺序</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns></returns>
        public async Task<List<T>> QueryListByClauseAsync(Expression<Func<T, bool>> predicate, int take,
            Expression<Func<T, object>> orderByPredicate, OrderByType orderByType, bool blUseNoLock = false)
        {
            return await _baseRepository.QueryListByClauseAsync(predicate, take, orderByPredicate, orderByType, blUseNoLock);
        }

        /// <summary>
        ///     根据条件查询一定数量数据
        /// </summary>
        /// <param name="predicate">条件表达式树</param>
        /// <param name="take">获取数量</param>
        /// <param name="strOrderByFileds">排序字段，如name asc,age desc</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns></returns>
        public List<T> QueryListByClause(Expression<Func<T, bool>> predicate, int take, string strOrderByFileds = "",
            bool blUseNoLock = false)
        {
            return _baseRepository.QueryListByClause(predicate, take, strOrderByFileds, blUseNoLock);
        }

        /// <summary>
        ///     根据条件查询一定数量数据
        /// </summary>
        /// <param name="predicate">条件表达式树</param>
        /// <param name="take">获取数量</param>
        /// <param name="strOrderByFileds">排序字段，如name asc,age desc</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns></returns>
        public async Task<List<T>> QueryListByClauseAsync(Expression<Func<T, bool>> predicate, int take,
            string strOrderByFileds = "", bool blUseNoLock = false)
        {
            return await _baseRepository.QueryListByClauseAsync(predicate, take, strOrderByFileds, blUseNoLock);
        }

        /// <summary>
        ///     根据条件查询数据
        /// </summary>
        /// <param name="predicate">条件表达式树</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns></returns>
        public T QueryByClause(Expression<Func<T, bool>> predicate, bool blUseNoLock = false)
        {
            return _baseRepository.QueryByClause(predicate, blUseNoLock);
        }

        /// <summary>
        ///     根据条件查询数据
        /// </summary>
        /// <param name="predicate">条件表达式树</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns></returns>
        public async Task<T> QueryByClauseAsync(Expression<Func<T, bool>> predicate, bool blUseNoLock = false)
        {
            return await _baseRepository.QueryByClauseAsync(predicate, blUseNoLock);
        }

        /// <summary>
        ///     根据条件查询数据
        /// </summary>
        /// <param name="predicate">条件表达式树</param>
        /// <param name="orderByPredicate">排序字段</param>
        /// <param name="orderByType">排序顺序</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns></returns>
        public T QueryByClause(Expression<Func<T, bool>> predicate, Expression<Func<T, object>> orderByPredicate,
            OrderByType orderByType, bool blUseNoLock = false)
        {
            var entity = _baseRepository.QueryByClause(predicate, orderByPredicate, orderByType, blUseNoLock);
            return entity;
        }

        /// <summary>
        ///     根据条件查询数据
        /// </summary>
        /// <param name="predicate">条件表达式树</param>
        /// <param name="orderByPredicate">排序字段</param>
        /// <param name="orderByType">排序顺序</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns></returns>
        public async Task<T> QueryByClauseAsync(Expression<Func<T, bool>> predicate,
            Expression<Func<T, object>> orderByPredicate, OrderByType orderByType, bool blUseNoLock = false)
        {
            return await _baseRepository.QueryByClauseAsync(predicate, orderByPredicate, orderByType, blUseNoLock);
        }

        /// <summary>
        ///     写入实体数据
        /// </summary>
        /// <param name="entity">实体数据</param>
        /// <returns></returns>
        public int Insert(T entity)
        {
            return _baseRepository.Insert(entity);
        }

        /// <summary>
        ///     写入实体数据
        /// </summary>
        /// <param name="entity">实体数据</param>
        /// <returns></returns>
        public async Task<int> InsertAsync(T entity)
        {
            return await _baseRepository.InsertAsync(entity);
        }

        /// <summary>
        ///     写入实体数据
        /// </summary>
        /// <param name="entity">实体数据</param>
        /// <param name="insertColumns">插入的列</param>
        /// <returns></returns>
        public int Insert(T entity, Expression<Func<T, object>> insertColumns = null)
        {
            return _baseRepository.Insert(entity, insertColumns);
        }

        /// <summary>
        ///     写入实体数据
        /// </summary>
        /// <param name="entity">实体数据</param>
        /// <param name="insertColumns">插入的列</param>
        /// <returns></returns>
        public async Task<int> InsertAsync(T entity, Expression<Func<T, object>> insertColumns = null)
        {
            return await _baseRepository.InsertAsync(entity, insertColumns);
        }

        /// <summary>
        ///     写入实体数据
        /// </summary>
        /// <param name="entity">实体类</param>
        /// <param name="insertColumns">需插入的字段</param>
        /// <returns></returns>
        public bool InsertGuid(T entity, Expression<Func<T, object>> insertColumns = null)
        {
            return _baseRepository.InsertGuid(entity, insertColumns);
        }

        /// <summary>
        ///     写入实体数据
        /// </summary>
        /// <param name="entity">实体类</param>
        /// <param name="insertColumns">需插入的字段</param>
        /// <returns></returns>
        public async Task<bool> InsertGuidAsync(T entity, Expression<Func<T, object>> insertColumns = null)
        {
            return await InsertGuidAsync(entity, insertColumns);
        }

        /// <summary>
        ///     批量写入实体数据
        /// </summary>
        /// <param name="entity">实体类</param>
        /// <returns></returns>
        public int Insert(List<T> entity)
        {
            return _baseRepository.Insert(entity);
        }

        /// <summary>
        ///     批量写入实体数据
        /// </summary>
        /// <param name="entity">实体类</param>
        /// <returns></returns>
        public async Task<int> InsertAsync(List<T> entity)
        {
            return await _baseRepository.InsertAsync(entity);
        }

        /// <summary>
        ///     批量写入实体数据
        /// </summary>
        /// <param name="entity">实体类</param>
        /// <returns></returns>
        public async Task<int> InsertCommandAsync(List<T> entity)
        {
            return await _baseRepository.InsertCommandAsync(entity);
        }

        /// <summary>
        ///     批量更新实体数据
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Update(List<T> entity)
        {
            return _baseRepository.Update(entity);
        }

        /// <summary>
        ///     批量更新实体数据
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<bool> UpdateAsync(List<T> entity)
        {
            return await _baseRepository.UpdateAsync(entity);
        }

        /// <summary>
        ///     更新实体数据
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Update(T entity)
        {
            return _baseRepository.Update(entity);
        }

        /// <summary>
        ///     更新实体数据
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<bool> UpdateAsync(T entity)
        {
            return await _baseRepository.UpdateAsync(entity);
        }

        /// <summary>
        ///     根据手写条件更新
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public bool Update(T entity, string strWhere)
        {
            return _baseRepository.Update(entity, strWhere);
        }

        /// <summary>
        ///     根据手写条件更新
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public async Task<bool> UpdateAsync(T entity, string strWhere)
        {
            return await _baseRepository.UpdateAsync(entity, strWhere);
        }

        /// <summary>
        ///     根据手写sql语句更新数据
        /// </summary>
        /// <param name="strSql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public bool Update(string strSql, SugarParameter[] parameters = null)
        {
            return _baseRepository.Update(strSql, parameters);
        }

        /// <summary>
        ///     根据手写sql语句更新数据
        /// </summary>
        /// <param name="strSql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public async Task<bool> UpdateAsync(string strSql, SugarParameter[] parameters = null)
        {
            return await _baseRepository.UpdateAsync(strSql, parameters);
        }

        /// <summary>
        ///     更新某个字段
        /// </summary>
        /// <param name="columns">lamdba表达式,如it => new Student() { Name = "a", CreateTime = DateTime.Now }</param>
        /// <param name="where">lamdba判断</param>
        /// <returns></returns>
        public bool Update(Expression<Func<T, T>> columns, Expression<Func<T, bool>> where)
        {
            return _baseRepository.Update(columns, where);
        }

        /// <summary>
        ///     更新某个字段
        /// </summary>
        /// <param name="columns">lamdba表达式,如it => new Student() { Name = "a", CreateTime = DateTime.Now }</param>
        /// <param name="where">lamdba判断</param>
        /// <returns></returns>
        public async Task<bool> UpdateAsync(Expression<Func<T, T>> columns, Expression<Func<T, bool>> where)
        {
            return await _baseRepository.UpdateAsync(columns, where);
        }

        /// <summary>
        ///     根据条件更新
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="lstColumns"></param>
        /// <param name="lstIgnoreColumns"></param>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public async Task<bool> UpdateAsync(T entity, List<string> lstColumns = null,
            List<string> lstIgnoreColumns = null, string strWhere = "")
        {
            return await _baseRepository.UpdateAsync(entity, lstColumns, lstIgnoreColumns, strWhere);
        }

        /// <summary>
        ///     根据条件更新
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="lstColumns"></param>
        /// <param name="lstIgnoreColumns"></param>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public bool Update(T entity, List<string> lstColumns = null, List<string> lstIgnoreColumns = null,
            string strWhere = "")
        {
            return _baseRepository.Update(entity, lstColumns, lstIgnoreColumns, strWhere);
        }

        /// <summary>
        ///     删除数据
        /// </summary>
        /// <param name="entity">实体类</param>
        /// <returns></returns>
        public bool Delete(T entity)
        {
            return _baseRepository.Delete(entity);
        }

        /// <summary>
        ///     删除数据
        /// </summary>
        /// <param name="entity">实体类</param>
        /// <returns></returns>
        public async Task<bool> DeleteAsync(T entity)
        {
            return await _baseRepository.DeleteAsync(entity);
        }

        /// <summary>
        ///     删除数据
        /// </summary>
        /// <param name="entity">实体类</param>
        /// <returns></returns>
        public bool Delete(IEnumerable<T> entity)
        {
            return _baseRepository.Delete(entity);
        }

        /// <summary>
        ///     删除数据
        /// </summary>
        /// <param name="entity">实体类</param>
        /// <returns></returns>
        public async Task<bool> DeleteAsync(IEnumerable<T> entity)
        {
            return await _baseRepository.DeleteAsync(entity);
        }

        /// <summary>
        ///     删除数据
        /// </summary>
        /// <param name="where">过滤条件</param>
        /// <returns></returns>
        public bool Delete(Expression<Func<T, bool>> where)
        {
            return _baseRepository.Delete(where);
        }

        /// <summary>
        ///     删除数据
        /// </summary>
        /// <param name="where">过滤条件</param>
        /// <returns></returns>
        public async Task<bool> DeleteAsync(Expression<Func<T, bool>> where)
        {
            return await _baseRepository.DeleteAsync(where);
        }

        /// <summary>
        ///     删除指定ID的数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteById(object id)
        {
            return _baseRepository.DeleteById(id);
        }

        /// <summary>
        ///     删除指定ID的数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> DeleteByIdAsync(object id)
        {
            return await _baseRepository.DeleteByIdAsync(id);
        }

        /// <summary>
        ///     删除指定ID集合的数据(批量删除)
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public bool DeleteByIds(int[] ids)
        {
            return _baseRepository.DeleteByIds(ids);
        }

        /// <summary>
        ///     删除指定ID集合的数据(批量删除)
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public async Task<bool> DeleteByIdsAsync(int[] ids)
        {
            return await _baseRepository.DeleteByIdsAsync(ids);
        }

        /// <summary>
        ///     删除指定ID集合的数据(批量删除)
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public bool DeleteByIds(long[] ids)
        {
            return _baseRepository.DeleteByIds(ids);
        }

        /// <summary>
        ///     删除指定ID集合的数据(批量删除)
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public async Task<bool> DeleteByIdsAsync(long[] ids)
        {
            return await _baseRepository.DeleteByIdsAsync(ids);
        }

        /// <summary>
        ///     删除指定ID集合的数据(批量删除)
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public bool DeleteByIds(Guid[] ids)
        {
            return _baseRepository.DeleteByIds(ids);
        }

        /// <summary>
        ///     删除指定ID集合的数据(批量删除)
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public async Task<bool> DeleteByIdsAsync(Guid[] ids)
        {
            return await _baseRepository.DeleteByIdsAsync(ids);
        }

        /// <summary>
        ///     删除指定ID集合的数据(批量删除)
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public bool DeleteByIds(string[] ids)
        {
            return _baseRepository.DeleteByIds(ids);
        }

        /// <summary>
        ///     删除指定ID集合的数据(批量删除)
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public async Task<bool> DeleteByIdsAsync(string[] ids)
        {
            return await _baseRepository.DeleteByIdsAsync(ids);
        }


        /// <summary>
        ///     删除指定ID集合的数据(批量删除)
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public bool DeleteByIds(List<int> ids)
        {
            return _baseRepository.DeleteByIds(ids);
        }

        /// <summary>
        ///     删除指定ID集合的数据(批量删除)
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public async Task<bool> DeleteByIdsAsync(List<int> ids)
        {
            return await _baseRepository.DeleteByIdsAsync(ids);
        }


        /// <summary>
        ///     删除指定ID集合的数据(批量删除)
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public bool DeleteByIds(List<string> ids)
        {
            return _baseRepository.DeleteByIds(ids);
        }

        /// <summary>
        ///     删除指定ID集合的数据(批量删除)
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public async Task<bool> DeleteByIdsAsync(List<string> ids)
        {
            return await _baseRepository.DeleteByIdsAsync(ids);
        }

        /// <summary>
        ///     删除指定ID集合的数据(批量删除)
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public bool DeleteByIds(List<Guid> ids)
        {
            return _baseRepository.DeleteByIds(ids);
        }

        /// <summary>
        ///     删除指定ID集合的数据(批量删除)
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public async Task<bool> DeleteByIdsAsync(List<Guid> ids)
        {
            return await _baseRepository.DeleteByIdsAsync(ids);
        }

        /// <summary>
        ///     删除指定ID集合的数据(批量删除)
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public bool DeleteByIds(List<long> ids)
        {
            return _baseRepository.DeleteByIds(ids);
        }

        /// <summary>
        ///     删除指定ID集合的数据(批量删除)
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public async Task<bool> DeleteByIdsAsync(List<long> ids)
        {
            return await _baseRepository.DeleteByIdsAsync(ids);
        }

        /// <summary>
        ///     判断数据是否存在
        /// </summary>
        /// <param name="predicate">条件表达式树</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns></returns>
        public bool Exists(Expression<Func<T, bool>> predicate, bool blUseNoLock = false)
        {
            return _baseRepository.Exists(predicate, blUseNoLock);
        }

        /// <summary>
        ///     判断数据是否存在
        /// </summary>
        /// <param name="predicate">条件表达式树</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns></returns>
        public async Task<bool> ExistsAsync(Expression<Func<T, bool>> predicate, bool blUseNoLock = false)
        {
            return await _baseRepository.ExistsAsync(predicate, blUseNoLock);
        }

        /// <summary>
        ///     获取数据总数
        /// </summary>
        /// <param name="predicate">条件表达式树</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns></returns>
        public int GetCount(Expression<Func<T, bool>> predicate, bool blUseNoLock = false)
        {
            return _baseRepository.GetCount(predicate, blUseNoLock);
        }

        /// <summary>
        ///     获取数据总数
        /// </summary>
        /// <param name="predicate">条件表达式树</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns></returns>
        public async Task<int> GetCountAsync(Expression<Func<T, bool>> predicate, bool blUseNoLock = false)
        {
            return await _baseRepository.GetCountAsync(predicate, blUseNoLock);
        }

        /// <summary>
        ///     获取数据某个字段的合计
        /// </summary>
        /// <param name="predicate">条件表达式树</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <param name="field">字段</param>
        /// <returns></returns>
        public int GetSum(Expression<Func<T, bool>> predicate, Expression<Func<T, int>> field, bool blUseNoLock = false)
        {
            return _baseRepository.GetSum(predicate, field, blUseNoLock);
        }

        /// <summary>
        ///     获取数据某个字段的合计
        /// </summary>
        /// <param name="predicate">条件表达式树</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <param name="field">字段</param>
        /// <returns></returns>
        public async Task<int> GetSumAsync(Expression<Func<T, bool>> predicate, Expression<Func<T, int>> field,
            bool blUseNoLock = false)
        {
            return await _baseRepository.GetSumAsync(predicate, field, blUseNoLock);
        }

        /// <summary>
        ///     获取数据某个字段的合计
        /// </summary>
        /// <param name="predicate">条件表达式树</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <param name="field">字段</param>
        /// <returns></returns>
        public decimal GetSum(Expression<Func<T, bool>> predicate, Expression<Func<T, decimal>> field,
            bool blUseNoLock = false)
        {
            return _baseRepository.GetSum(predicate, field, blUseNoLock);
        }

        /// <summary>
        ///     获取数据某个字段的合计
        /// </summary>
        /// <param name="predicate">条件表达式树</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <param name="field">字段</param>
        /// <returns></returns>
        public async Task<decimal> GetSumAsync(Expression<Func<T, bool>> predicate, Expression<Func<T, decimal>> field,
            bool blUseNoLock = false)
        {
            return await _baseRepository.GetSumAsync(predicate, field, blUseNoLock);
        }

        /// <summary>
        ///     获取数据某个字段的合计
        /// </summary>
        /// <param name="predicate">条件表达式树</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <param name="field">字段</param>
        /// <returns></returns>
        public float GetSum(Expression<Func<T, bool>> predicate, Expression<Func<T, float>> field,
            bool blUseNoLock = false)
        {
            return _baseRepository.GetSum(predicate, field, blUseNoLock);
        }

        /// <summary>
        ///     获取数据某个字段的合计
        /// </summary>
        /// <param name="predicate">条件表达式树</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <param name="field">字段</param>
        /// <returns></returns>
        public async Task<float> GetSumAsync(Expression<Func<T, bool>> predicate, Expression<Func<T, float>> field,
            bool blUseNoLock = false)
        {
            return await _baseRepository.GetSumAsync(predicate, field, blUseNoLock);
        }

        /// <summary>
        ///     根据条件查询分页数据
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="orderBy"></param>
        /// <param name="pageIndex">当前页面索引</param>
        /// <param name="pageSize">分布大小</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns></returns>
        public IPageList<T> QueryPage(Expression<Func<T, bool>> predicate, string orderBy = "", int pageIndex = 1,
            int pageSize = 20, bool blUseNoLock = false)
        {
            return _baseRepository.QueryPage(predicate, orderBy, pageIndex, pageSize, blUseNoLock);
        }

        /// <summary>
        ///     根据条件查询分页数据
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="orderBy"></param>
        /// <param name="pageIndex">当前页面索引</param>
        /// <param name="pageSize">分布大小</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns></returns>
        public async Task<IPageList<T>> QueryPageAsync(Expression<Func<T, bool>> predicate, string orderBy = "",
            int pageIndex = 1, int pageSize = 20, bool blUseNoLock = false)
        {
            return await _baseRepository.QueryPageAsync(predicate, orderBy, pageIndex, pageSize, blUseNoLock);
        }

        /// <summary>
        ///     根据条件查询分页数据
        /// </summary>
        /// <param name="predicate">判断集合</param>
        /// <param name="orderByType">排序方式</param>
        /// <param name="pageIndex">当前页面索引</param>
        /// <param name="pageSize">分布大小</param>
        /// <param name="orderByExpression"></param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns></returns>
        public IPageList<T> QueryPage(Expression<Func<T, bool>> predicate,
            Expression<Func<T, object>> orderByExpression, OrderByType orderByType, int pageIndex = 1,
            int pageSize = 20, bool blUseNoLock = false)
        {
            return _baseRepository.QueryPage(predicate, orderByExpression, orderByType, pageIndex, pageSize, blUseNoLock);
        }

        /// <summary>
        ///     根据条件查询分页数据
        /// </summary>
        /// <param name="predicate">判断集合</param>
        /// <param name="orderByType">排序方式</param>
        /// <param name="pageIndex">当前页面索引</param>
        /// <param name="pageSize">分布大小</param>
        /// <param name="orderByExpression"></param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns></returns>
        public async Task<IPageList<T>> QueryPageAsync(Expression<Func<T, bool>> predicate,
            Expression<Func<T, object>> orderByExpression, OrderByType orderByType, int pageIndex = 1,
            int pageSize = 20, bool blUseNoLock = false)
        {
            return await _baseRepository.QueryPageAsync(predicate, orderByExpression, orderByType, pageIndex, pageSize,
                blUseNoLock);
        }

        /// <summary>
        ///     查询-多表查询
        /// </summary>
        /// <typeparam name="T1">实体1</typeparam>
        /// <typeparam name="T2">实体2</typeparam>
        /// <typeparam name="TResult">返回对象</typeparam>
        /// <param name="joinExpression">关联表达式 (join1,join2) => new object[] {JoinType.Left,join1.UserNo==join2.UserNo}</param>
        /// <param name="selectExpression">返回表达式 (s1, s2) => new { Id =s1.UserNo, Id1 = s2.UserNo}</param>
        /// <param name="whereLambda">查询表达式 (w1, w2) =>w1.UserNo == "")</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns>值</returns>
        public List<TResult> QueryMuch<T1, T2, TResult>(
            Expression<Func<T1, T2, object[]>> joinExpression,
            Expression<Func<T1, T2, TResult>> selectExpression,
            Expression<Func<T1, T2, bool>> whereLambda = null, bool blUseNoLock = false) where T1 : class, new()
        {
            return _baseRepository.QueryMuch(joinExpression, selectExpression, whereLambda, blUseNoLock);
        }

        /// <summary>
        ///     查询-多表查询
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
            Expression<Func<T1, T2, bool>> whereLambda = null, bool blUseNoLock = false) where T1 : class, new()
        {
            return await _baseRepository.QueryMuchAsync(joinExpression, selectExpression, whereLambda, blUseNoLock);
        }

        /// <summary>
        ///     查询-多表查询
        /// </summary>
        /// <typeparam name="T1">实体1</typeparam>
        /// <typeparam name="T2">实体2</typeparam>
        /// <typeparam name="TResult">返回对象</typeparam>
        /// <param name="joinExpression">关联表达式 (join1,join2) => new object[] {JoinType.Left,join1.UserNo==join2.UserNo}</param>
        /// <param name="selectExpression">返回表达式 (s1, s2) => new { Id =s1.UserNo, Id1 = s2.UserNo}</param>
        /// <param name="whereLambda">查询表达式 (w1, w2) =>w1.UserNo == "")</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns>值</returns>
        public TResult QueryMuchFirst<T1, T2, TResult>(
            Expression<Func<T1, T2, object[]>> joinExpression,
            Expression<Func<T1, T2, TResult>> selectExpression,
            Expression<Func<T1, T2, bool>> whereLambda = null, bool blUseNoLock = false) where T1 : class, new()
        {
            return _baseRepository.QueryMuchFirst(joinExpression, selectExpression, whereLambda, blUseNoLock);
        }

        /// <summary>
        ///     查询-多表查询
        /// </summary>
        /// <typeparam name="T1">实体1</typeparam>
        /// <typeparam name="T2">实体2</typeparam>
        /// <typeparam name="TResult">返回对象</typeparam>
        /// <param name="joinExpression">关联表达式 (join1,join2) => new object[] {JoinType.Left,join1.UserNo==join2.UserNo}</param>
        /// <param name="selectExpression">返回表达式 (s1, s2) => new { Id =s1.UserNo, Id1 = s2.UserNo}</param>
        /// <param name="whereLambda">查询表达式 (w1, w2) =>w1.UserNo == "")</param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns>值</returns>
        public async Task<TResult> QueryMuchFirstAsync<T1, T2, TResult>(
            Expression<Func<T1, T2, object[]>> joinExpression,
            Expression<Func<T1, T2, TResult>> selectExpression,
            Expression<Func<T1, T2, bool>> whereLambda = null, bool blUseNoLock = false) where T1 : class, new()
        {
            return await _baseRepository.QueryMuchFirstAsync(joinExpression, selectExpression, whereLambda, blUseNoLock);
        }

        /// <summary>
        ///     查询-三表查询
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
        public List<TResult> QueryMuch<T1, T2, T3, TResult>(
            Expression<Func<T1, T2, T3, object[]>> joinExpression,
            Expression<Func<T1, T2, T3, TResult>> selectExpression,
            Expression<Func<T1, T2, T3, bool>> whereLambda = null, bool blUseNoLock = false) where T1 : class, new()
        {
            return _baseRepository.QueryMuch(joinExpression, selectExpression, whereLambda, blUseNoLock);
        }

        /// <summary>
        ///     查询-三表查询
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
        public async Task<List<TResult>> QueryMuchAsync<T1, T2, T3, TResult>(
            Expression<Func<T1, T2, T3, object[]>> joinExpression,
            Expression<Func<T1, T2, T3, TResult>> selectExpression,
            Expression<Func<T1, T2, T3, bool>> whereLambda = null, bool blUseNoLock = false) where T1 : class, new()
        {
            return await _baseRepository.QueryMuchAsync(joinExpression, selectExpression, whereLambda, blUseNoLock);
        }

        /// <summary>
        ///     执行sql语句并返回List<T>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public List<T> SqlQuery(string sql, List<SugarParameter> parameters)
        {
            return _baseRepository.SqlQuery(sql, parameters);
        }

        /// <summary>
        ///     执行sql语句并返回List<T>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <returns></returns>
        public async Task<List<T>> SqlQueryable(string sql)
        {
            return await _baseRepository.SqlQueryable(sql);
        }

        public T QuseryByClause(Expression<Func<T, bool>> predicate, bool blUseNoLock = false)
        {
            throw new NotImplementedException();
        }

        public Task<T> QuseryByClauseAsync(Expression<Func<T, bool>> predicate, bool blUseNoLock = false)
        {
            throw new NotImplementedException();
        }

        public int Insert(T entity, Expression<Func<T, bool>> insertColumns = null)
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertAsync(T entity, Expression<Func<T, bool>> insertColumns = null)
        {
            throw new NotImplementedException();
        }

        public bool InsertGuid(T entity, Expression<Func<T, bool>> insertColumns = null)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertGuidAsync(T entity, Expression<Func<T, bool>> insertColumns = null)
        {
            throw new NotImplementedException();
        }

        Task IBaseService<T>.UpdateAsync(T entity, string strWhere)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(T entity, List<string> lstcolumn = null, List<string> lstIngoreColumns = null)
        {
            throw new NotImplementedException();
        }
    }
}
