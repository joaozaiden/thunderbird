using System;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using Thunderbird.Business.Repository;

namespace Thunderbird.Business.Implementation
{

    public class RepositoryBase<T> : IRepositoryBase<T>
    {
        private static ISessionFactory _sessionFactory;

        public static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    var configuration = new Configuration();
                    configuration.Configure();
                    configuration.AddAssembly(typeof(T).Assembly);
                    _sessionFactory = configuration.BuildSessionFactory();
                }
                return _sessionFactory;
            }
        }

        public void CloseSession()
        {
            if (!_sessionFactory.IsClosed)
            {
                _sessionFactory.Close();
                _sessionFactory.Dispose();
            }
        }

        public T Salvar(T entity)
        {
            try
            {
                using (ISession session = SessionFactory.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Save(entity);
                        transaction.Commit();
                    }
                }

                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public T Alterar(T entity)
        {
            try
            {
                using (ISession session = SessionFactory.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Update(entity);
                        transaction.Commit();
                    }
                }

                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Excluir(T entity)
        {
            try
            {
                using (ISession session = SessionFactory.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Delete(entity);
                        transaction.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public T ObterPorId(int id)
        {
            try
            {
                using (ISession session = SessionFactory.OpenSession())
                {
                    return session.Get<T>(id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IList<T> ObterTodos()
        {
            IList<T> lista;

            try
            {
                using (ISession session = SessionFactory.OpenSession())
                {
                    lista = session.CreateCriteria(typeof(T)).List<T>();
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
