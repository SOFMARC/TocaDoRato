using AutoMapper;

namespace ProjetoLoja.AutoMapper
{
    public static class AutoMapperHelper
    {
        public static I CreateMapper<T, I>(object objectToMapper)
        {
            I destiny = Mapper.DynamicMap<I>(objectToMapper);            
            return destiny;
        }
    }
}

