using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace NewsApp.Themes
{
    public class ThemeAppService : NewsAppAppService, 
    IThemeAppService 
    {
        private readonly IRepository<Theme, int> _repository;

        //Siempre que hagamos un appService, tenemos que heredar de NewsAppAppService
        public ThemeAppService(IRepository<Theme, int> repository)
        {
            //IRepository es la interfaz con la cual podemos interactuar con la base de datos (para consultas o persistir informacion)
            _repository = repository;
        }

        //---------primera version para consultar
        public async Task<ICollection<ThemeDto>> GetThemesAsync()
        {
        //para usar metodos asincronicos, se debe colocar el "await" antes
            var themes = await _repository.GetListAsync();

            return ObjectMapper.Map<ICollection<Theme>, ICollection<ThemeDto>>(themes);
        }
        
        //---------version de consulta final (muestra los datos del usuario)
        public async Task<ThemeDto>GetThemesAsync(int id)
        {
            var queryable = await _repository.WithDetailsAsync(x => x.User);
            var query = queryable.Where(x => x.Id == id);
            var theme = await AsyncExecuter.FirstOrDefaultAsync(query);
            return ObjectMapper.Map<Theme, ThemeDto>(theme);
        }
    }
}
