using AutoMapper;
using ComprasNerd.ProdutoAPI.Data.ValueObject;
using ComprasNerd.ProdutoAPI.Model;

namespace ComprasNerd.ProdutoAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config => {

                config.CreateMap<ProdutoVO, Produto>();
                config.CreateMap<Produto, ProdutoVO>();
            
            });

            return mappingConfig;
        }

    }
}
