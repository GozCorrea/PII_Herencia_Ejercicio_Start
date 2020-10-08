namespace UCURide
{
    public abstract class Usuario
    {
        private string nombre;
        private string apellido;
        private string cedula;
        private string foto;
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }
        public string Cedula
        {
            get
            {
                return this.cedula;
            }
        }
        public string Foto
        {
            get
            {
                return this.foto;
            }
        }


    }
}