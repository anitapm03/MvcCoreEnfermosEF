using MvcCoreEnfermosEF.Data;
using MvcCoreEnfermosEF.Models;

namespace MvcCoreEnfermosEF.Repositories
{
    public class RepositoryEnfermo
    {
        private EnfermoContext context;

        public RepositoryEnfermo(EnfermoContext context)
        {
            this.context = context;
        }

        public List<Enfermo> GetEnfermos()
        {
            var consulta = from datos in this.context.Enfermos
                           select datos;
            return consulta.ToList();
        }
    }
}
