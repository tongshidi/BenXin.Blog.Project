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


    public bool Delete(T entity)
    {
      return _baseRepository.Delete(entity);
    }

    public bool Delete(IEnumerable<T> entity)
    {
      return _baseRepository.Delete(entity);
    }

    public bool Delete(Expression<Func<T, bool>> where)
    {
      return _baseRepository.Delete(where);
    }

    public Task<bool> DeleteAsync(T entity)
    {
      throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(IEnumerable<T> entity)
    {
      throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(Expression<Func<T, bool>> where)
    {
      throw new NotImplementedException();
    }

    public bool DeleteById(object id)
    {
      throw new NotImplementedException();
    }

    public Task<bool> DeleteByIdAsync(object id)
    {
      throw new NotImplementedException();
    }

    public bool DeleteByIds(int[] ids)
    {
      throw new NotImplementedException();
    }

    public bool DeleteByIds(long[] ids)
    {
      throw new NotImplementedException();
    }

    public bool DeleteByIds(Guid[] ids)
    {
      throw new NotImplementedException();
    }

    public bool DeleteByIds(string[] ids)
    {
      throw new NotImplementedException();
    }

    public bool DeleteByIds(List<int> ids)
    {
      throw new NotImplementedException();
    }

    public bool DeleteByIds(List<string> ids)
    {
      throw new NotImplementedException();
    }

    public bool DeleteByIds(List<Guid> ids)
    {
      throw new NotImplementedException();
    }

    public bool DeleteByIds(List<long> ids)
    {
      throw new NotImplementedException();
    }

    public Task<bool> DeleteByIdsAsync(int[] ids)
    {
      throw new NotImplementedException();
    }

    public Task<bool> DeleteByIdsAsync(long[] ids)
    {
      throw new NotImplementedException();
    }

    public Task<bool> DeleteByIdsAsync(Guid[] ids)
    {
      throw new NotImplementedException();
    }

    public Task<bool> DeleteByIdsAsync(string[] ids)
    {
      throw new NotImplementedException();
    }

    public Task<bool> DeleteByIdsAsync(List<int> ids)
    {
      throw new NotImplementedException();
    }

    public Task<bool> DeleteByIdsAsync(List<string> ids)
    {
      throw new NotImplementedException();
    }

    public Task<bool> DeleteByIdsAsync(List<Guid> ids)
    {
      throw new NotImplementedException();
    }

    public Task<bool> DeleteByIdsAsync(List<long> ids)
    {
      throw new NotImplementedException();
    }

    public bool Exists(Expression<Func<T, bool>> predicate, bool blUseNoLock = false)
    {
      throw new NotImplementedException();
    }

    public Task<bool> ExistsAsync(Expression<Func<T, bool>> predicate, bool blUseNoLock = false)
    {
      throw new NotImplementedException();
    }

    public int GetCount(Expression<Func<T, bool>> predicate, bool blUseNoLock = false)
    {
      throw new NotImplementedException();
    }

    public Task<int> GetCountAsync(Expression<Func<T, bool>> predicate, bool blUseNoLock = false)
    {
      throw new NotImplementedException();
    }

    public int GetSum(Expression<Func<T, bool>> predicate, Expression<Func<T, int>> field, bool blUseNoLock = false)
    {
      throw new NotImplementedException();
    }

    public decimal GetSum(Expression<Func<T, bool>> predicate, Expression<Func<T, decimal>> field, bool blUseNoLock = false)
    {
      throw new NotImplementedException();
    }

    public float GetSum(Expression<Func<T, bool>> predicate, Expression<Func<T, float>> field, bool blUseNoLock = false)
    {
      throw new NotImplementedException();
    }

    public Task<int> GetSumAsync(Expression<Func<T, bool>> predicate, Expression<Func<T, int>> field, bool blUseNoLock = false)
    {
      throw new NotImplementedException();
    }

    public Task<decimal> GetSumAsync(Expression<Func<T, bool>> predicate, Expression<Func<T, decimal>> field, bool blUseNoLock = false)
    {
      throw new NotImplementedException();
    }

    public Task<float> GetSumAsync(Expression<Func<T, bool>> predicate, Expression<Func<T, float>> field, bool blUseNoLock = false)
    {
      throw new NotImplementedException();
    }

    public int Insert(T entity)
    {
      throw new NotImplementedException();
    }

    public int Insert(T entity, Expression<Func<T, bool>> insertColumns = null)
    {
      throw new NotImplementedException();
    }

    public int Insert(List<T> enntity)
    {
      throw new NotImplementedException();
    }

    public Task<int> InsertAsync(T entity)
    {
      throw new NotImplementedException();
    }

    public Task<int> InsertAsync(T entity, Expression<Func<T, bool>> insertColumns = null)
    {
      throw new NotImplementedException();
    }

    public Task<int> InsertAsync(List<T> enntity)
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

    public List<T> Query(bool blUseNoLock = false)
    {
      throw new NotImplementedException();
    }

    public Task<List<T>> QueryAsync(bool blUseNoLock = false)
    {
      throw new NotImplementedException();
    }

    public T QueryByClause(Expression<Func<T, bool>> predicate, Expression<Func<T, object>> orderByPredicate, OrderByType orderByType, bool blUseNoLock = false)
    {
      throw new NotImplementedException();
    }

    public Task<T> QueryByClauseAsync(Expression<Func<T, bool>> predicate, Expression<Func<T, object>> orderByPredicate, OrderByType orderByType, bool blUseNoLock = false)
    {
      throw new NotImplementedException();
    }

    public T QueryById(object pkValue, bool blUseNoLock = false)
    {
      throw new NotImplementedException();
    }

    public Task<T> QueryByIdAsync(object objId, bool blUseNoLock = false)
    {
      throw new NotImplementedException();
    }

    public List<T> QueryByIDs(object[] lstIds, bool blUseNoLock = false)
    {
      throw new NotImplementedException();
    }

    public Task<List<T>> QueryByIDsAsync(object[] lstIds, bool blUseNoLock = false)
    {
      throw new NotImplementedException();
    }

    public List<T> QueryListByClause(string strWhere, string orderBy = "", bool blUseNoLock = false)
    {
      throw new NotImplementedException();
    }

    public List<T> QueryListByClause(Expression<Func<T, bool>> predicate, string orderBy = "", bool blUseNoLock = false)
    {
      throw new NotImplementedException();
    }

    public List<T> QueryListByClause(Expression<Func<T, bool>> predicate, Expression<Func<T, object>> orderPredicate, OrderByType orderByType, bool blUseNoLock = false)
    {
      throw new NotImplementedException();
    }

    public List<T> QueryListByClause(Expression<Func<T, bool>> predicate, int take, Expression<Func<T, object>> orderPredicate, OrderByType orderByType, bool blUseNoLock = false)
    {
      throw new NotImplementedException();
    }

    public List<T> QueryListByClause(Expression<Func<T, bool>> predicate, int take, string strOrderByFileds = "", bool blUseNoLock = false)
    {
      throw new NotImplementedException();
    }

    public Task<List<T>> QueryListByClauseAsync(string strWhere, string orderBy = "", bool blUseNoLock = false)
    {
      throw new NotImplementedException();
    }

    public Task<List<T>> QueryListByClauseAsync(Expression<Func<T, bool>> predicate, string orderBy = "", bool blUseNoLock = false)
    {
      throw new NotImplementedException();
    }

    public Task<List<T>> QueryListByClauseAsync(Expression<Func<T, bool>> predicate, Expression<Func<T, object>> orderByPredicate, OrderByType orderByType, bool blUseNoLock = false)
    {
      throw new NotImplementedException();
    }

    public Task<List<T>> QueryListByClauseAsync(Expression<Func<T, bool>> predicate, int take, Expression<Func<T, object>> orderPredicate, OrderByType orderByType, bool blUseNoLock = false)
    {
      throw new NotImplementedException();
    }

    public Task<List<T>> QueryListByClauseAsync(Expression<Func<T, bool>> predicate, int take, string strOrderByFileds = "", bool blUseNoLock = false)
    {
      throw new NotImplementedException();
    }

    public List<TResult> QueryMuch<T1, T2, TResult>(Expression<Func<T1, T2, object[]>> joinExpression, Expression<Func<T1, T2, TResult>> selectExpression, Expression<Func<T1, T2, bool>> whereLambda = null, bool blUseNoLock = false) where T1 : class, new()
    {
      throw new NotImplementedException();
    }

    public List<TResult> QueryMuch<T1, T2, T3, TResult>(Expression<Func<T1, T2, T3, object[]>> joinExpression, Expression<Func<T1, T2, T3, TResult>> selectExpression, Expression<Func<T1, T2, T3, bool>> whereLambda = null, bool blUseNoLock = false) where T1 : class, new()
    {
      throw new NotImplementedException();
    }

    public Task<List<TResult>> QueryMuchAsync<T1, T2, T3, TResult>(Expression<Func<T1, T2, T3, object[]>> joinExpression, Expression<Func<T1, T2, T3, TResult>> selectExpression, Expression<Func<T1, T2, T3, bool>> whereLambda = null, bool blUseNoLock = false) where T1 : class, new()
    {
      throw new NotImplementedException();
    }

    public TResult QueryMuchFirst<T1, T2, TResult>(Expression<Func<T1, T2, object[]>> joinExpression, Expression<Func<T1, T2, TResult>> selectExpression, Expression<Func<T1, T2, bool>> whereLambda = null, bool blUseNoLock = false) where T1 : class, new()
    {
      throw new NotImplementedException();
    }

    public Task<TResult> QueryMuchFirstAsync<T1, T2, TResult>(Expression<Func<T1, T2, object[]>> joinExpression, Expression<Func<T1, T2, TResult>> selectExpression, Expression<Func<T1, T2, bool>> whereLambda = null, bool blUseNoLock = false) where T1 : class, new()
    {
      throw new NotImplementedException();
    }

    public IPageList<T> QueryPage(Expression<Func<T, bool>> predicate, string orderBy = "", int pageIndex = 1, int pageSize = 20, bool blUseNoLock = false)
    {
      throw new NotImplementedException();
    }

    public IPageList<T> QueryPage(Expression<Func<T, bool>> predicate, Expression<Func<T, object>> orderByExpression, OrderByType orderByType, int pageIndex = 1, int pageSize = 20, bool blUseNoLock = false)
    {
      throw new NotImplementedException();
    }

    public Task<IPageList<T>> QueryPageAsync(Expression<Func<T, bool>> predicate, string orderBy = "", int pageIndex = 1, int pageSize = 20, bool blUseNoLock = false)
    {
      throw new NotImplementedException();
    }

    public Task<IPageList<T>> QueryPageAsync(Expression<Func<T, bool>> predicate, Expression<Func<T, object>> orderByExpression, OrderByType orderByType, int pageIndex = 1, int pageSize = 20, bool blUseNoLock = false)
    {
      throw new NotImplementedException();
    }

    public T QuseryByClause(Expression<Func<T, bool>> predicate, bool blUseNoLock = false)
    {
      throw new NotImplementedException();
    }

    public Task<T> QuseryByClauseAsync(Expression<Func<T, bool>> predicate, bool blUseNoLock = false)
    {
      throw new NotImplementedException();
    }

    public List<T> SqlQuery(string sql, List<SugarParameter> parameters)
    {
      throw new NotImplementedException();
    }

    public Task<List<T>> SqlQueryable(string sql)
    {
      throw new NotImplementedException();
    }

    public bool Update(List<T> entity)
    {
      throw new NotImplementedException();
    }

    public bool Update(T entity)
    {
      throw new NotImplementedException();
    }

    public bool Update(T entity, string strWhere)
    {
      throw new NotImplementedException();
    }

    public bool Update(string strSql, SugarParameter[] parameters = null)
    {
      throw new NotImplementedException();
    }

    public bool Update(Expression<Func<T, T>> columns, Expression<Func<T, bool>> where)
    {
      throw new NotImplementedException();
    }

    public bool Update(T entity, List<string> lstColumns = null, List<string> lstIgnoreColumns = null, string strWhere = "")
    {
      throw new NotImplementedException();
    }

    public Task<bool> UpdateAsync(List<T> entity)
    {
      throw new NotImplementedException();
    }

    public Task<bool> UpdateAsync(T entity)
    {
      throw new NotImplementedException();
    }

    public Task UpdateAsync(T entity, string strWhere)
    {
      throw new NotImplementedException();
    }

    public Task<bool> UpdateAsync(string strSql, SugarParameter[] parameters = null)
    {
      throw new NotImplementedException();
    }

    public Task<bool> UpdateAsync(Expression<Func<T, T>> columns, Expression<Func<T, bool>> where)
    {
      throw new NotImplementedException();
    }

    public Task<bool> UpdateAsync(T entity, List<string> lstcolumn = null, List<string> lstIngoreColumns = null)
    {
      throw new NotImplementedException();
    }
  }
}
