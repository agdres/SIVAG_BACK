using Microsoft.AspNetCore.SignalR;
using SIVAG_BACKEND.Interfaces;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Hubs
{
    public class Hub_Generales : Hub
    {
        private ITipos_Documentos _TiposDocumentos;
        private IPaises _Paises;
        private IDepartamentos _Departamentos;
        private IMunicipios _Municipios;
        private IMonedas _Monedas;
        private IFormas_Pago _FormasPago;
        private IMedios_Pago _MediosPago;
        public Hub_Generales
        (
            ITipos_Documentos tiposDocumentos,
            IPaises paises,
            IDepartamentos departamentos,
            IMunicipios municipios,
            IMonedas monedas,
            IFormas_Pago formasPago,
            IMedios_Pago mediosPago
        ) 
        {
            _TiposDocumentos= tiposDocumentos;
            _Paises= paises;    
            _Departamentos= departamentos;
            _Municipios= municipios;
            _Monedas= monedas;
            _FormasPago= formasPago;
            _MediosPago= mediosPago;
        }

        #region Consulta Los activos (Esto es para todos los usuarios esten conectados a los cambios del supervisor)
        public async Task GetTipos_Documentos()
        {
            List<Tipos_DocumentosDTO> TiposDocumentos = await this._TiposDocumentos.GetTipDocActivos();
            await Clients.All.SendAsync("GetTipos_Documentos", TiposDocumentos);
        }    

        public async Task GetPaises()
        {
            List<PaisesDTO> TiposDocumentos = await this._Paises.GetPaisesActivos();
            await Clients.All.SendAsync("GetPaises", TiposDocumentos);
        }   

        public async Task GetDepartamentos(int Pais)
        {
            List<DepartamentosDTO> TiposDocumentos = await this._Departamentos.GetDepartamentosActivos(Pais);
            await Clients.All.SendAsync("GetDepartamentos", TiposDocumentos);
        }    


        public async Task GetMunicipios(int Departamento)
        {
            List<MunicipiosDTO> TiposDocumentos = await this._Municipios.GetMunicipiosActivos(Departamento);
            await Clients.All.SendAsync("GetMunicipios", TiposDocumentos);
        }
        #endregion
    }
}
