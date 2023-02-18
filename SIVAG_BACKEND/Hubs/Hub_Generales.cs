using Microsoft.AspNetCore.SignalR;
using SIVAG_BACKEND.Core.Domain;
using SIVAG_BACKEND.Interfaces;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Hubs
{
    public class Hub_Generales : Hub
    {
        private ITipos_Documentos _TiposDocumentos;
        private IMensajes _Mensajes;
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
            IMedios_Pago mediosPago,
            IMensajes mensajes
        ) 
        {
            _TiposDocumentos= tiposDocumentos;
            _Mensajes = mensajes;
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
        public async Task GetMensajes()
        {
            List<MensajesDomain> Mensajes = await this._Mensajes.GetMensajeAlert();
            await Clients.All.SendAsync("GetMensajes", Mensajes);
        }    

        public async Task GetPaises()
        {
            List<PaisesDTO> Paises = await this._Paises.GetPaisesActivos();
            await Clients.All.SendAsync("GetPaises", Paises);
        }   

        public async Task GetDepartamentos(int Pais)
        {
            List<DepartamentosDTO> Departamentos = await this._Departamentos.GetDepartamentosActivos(Pais);
            await Clients.All.SendAsync("GetDepartamentos", Departamentos);
        }    


        public async Task GetMunicipios(int Departamento)
        {
            List<MunicipiosDTO> Municipios = await this._Municipios.GetMunicipiosActivos(Departamento);
            await Clients.All.SendAsync("GetMunicipios", Municipios);
        }       


        public async Task GetMonedas()
        {
            List<MonedasDTO> Monedas = await this._Monedas.GetMonedasActivos();
            await Clients.All.SendAsync("GetMonedas", Monedas);
        }


        public async Task GetFormas_Pago()
        {
            List<Formas_PagoDTO> FormasPago = await this._FormasPago.GetFormasPagosActivos();
            await Clients.All.SendAsync("GetFormas_Pago", FormasPago);
        }


        public async Task GetMedios_Pago()
        {
            List<Medios_PagoDTO> MediosPago = await this._MediosPago.GetFormasPagosActivos();
            await Clients.All.SendAsync("GetMedios_Pago", MediosPago);
        }
        #endregion
    }
}
