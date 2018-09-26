using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NH.Bencher;
using NHibernate;
using NHibernate.Linq;

namespace RawBencher.Benchers
{
    public class NHibernateNoChangeTrackingBencher : BencherBase<NH.Bencher.EntityClasses.SalesOrderHeader>
    {
        public NHibernateNoChangeTrackingBencher()
            : base(e => e.SalesOrderId, usesChangeTracking: false, usesCaching: false)
        {
        }

        /// <summary>
        /// Fetches the individual element
        /// </summary>
        /// <param name="key">The key of the element to fetch.</param>
        /// <returns>The fetched element, or null if not found</returns>
        public override NH.Bencher.EntityClasses.SalesOrderHeader FetchIndividual(int key)
        {
            //return SessionManager.StatelessSession.Get<NH.Bencher.EntityClasses.SalesOrderHeader>(key);

            using (var session = SessionManager.OpenStatelessSession())
            {
                return session.Get<NH.Bencher.EntityClasses.SalesOrderHeader>(key);
            }
        }

        /// <summary>
        /// Fetches the complete set of elements and returns this set as an IEnumerable.
        /// </summary>
        /// <returns>the set fetched</returns>
        public override IEnumerable<NH.Bencher.EntityClasses.SalesOrderHeader> FetchSet()
        {
            //return SessionManager.StatelessSession.Query<NH.Bencher.EntityClasses.SalesOrderHeader>().ToList();

            using (var session = SessionManager.OpenStatelessSession())
            {
                return session.Query<NH.Bencher.EntityClasses.SalesOrderHeader>().ToList();
            }
        }

        /// <summary>
        /// Creates the name of the framework this bencher is for. Use the overload which accepts a format string and a type to create a name based on a
        /// specific version
        /// </summary>
        /// <returns>the framework name.</returns>
        protected override string CreateFrameworkNameImpl()
        {
            return CreateFrameworkName("NHibernate v{0} (v{1})", typeof(ISession));
        }
    }
}
