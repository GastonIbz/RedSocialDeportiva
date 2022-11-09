namespace RedSocialDeportiva.Client.Servicios
{
    public class HttpRespuesta <T>
    {
        public T Respuesta { get; }
        public bool Error { get; }
        public HttpResponseMessage HtttpResponse { get; }
        public HttpRespuesta(T respuesta, bool error, HttpResponseMessage htttpResponse)
        {
            Respuesta = respuesta;
            Error = error;
            HtttpResponse = htttpResponse;
        }
    }
}
