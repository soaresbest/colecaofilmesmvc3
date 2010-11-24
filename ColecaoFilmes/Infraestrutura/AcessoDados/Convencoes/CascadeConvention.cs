using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Instances;

namespace ColecaoFilmes.Data.RepositorioSqlNhibernate.Conventions
{
    public class CascadeConvention : IReferenceConvention, IHasManyConvention, IHasManyToManyConvention
    {
        #region IHasManyConvention Members

        public void Apply(IOneToManyCollectionInstance instance)
        {
            instance.Cascade.All();
            instance.Inverse();
        }

        #endregion

        #region IHasManyToManyConvention Members

        public void Apply(IManyToManyCollectionInstance instance)
        {
        }

        #endregion

        #region IReferenceConvention Members

        public void Apply(IManyToOneInstance instance)
        {
        }

        #endregion

        public void Apply(IOneToOneInstance instance)
        {
        }
    }
}