using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace NewsApp.Themes
{
    public interface IThemeAppService : IApplicationService
    {
        //Es conveniente que sean asincronicas para mejor rendimiento
        //en aplicaciones cliente-servidor

        //metodo asincronico
        Task<ICollection<ThemeDto>> GetThemesAsync();

        //metodo sincronico (no lo usamos)
        //ICollection<ThemeDto> GetThemes();


        //prueba para obtener 1 solo tema (get con id)
        Task<ThemeDto> GetThemesAsync(int id);
    }
}
