using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrismJPKEditor.Services
{
    public static class MapperHelper
    {
        public static TDestination Map<TDestination>(Action<IMapperConfigurationExpression> configure, object source) where TDestination : class
        {
            var mapperConfiguration = new MapperConfiguration(configure);
            IMapper mapper = mapperConfiguration.CreateMapper();
            return mapper.Map<TDestination>(source);
        }
    }
}
