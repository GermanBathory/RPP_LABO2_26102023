namespace Entidades
{
    public abstract class Vehiculo
    {
        protected bool esAWD;
        protected Guid numeroDeChasis;
        private EPropulsion propulsion;

        protected Vehiculo(EPropulsion propulsion)
        {
            this.propulsion = propulsion;
            this.esAWD = false;
        }

        protected Vehiculo(EPropulsion propulsion, bool esAWD) : this(propulsion)
        {
            this.esAWD = esAWD;
            this.numeroDeChasis = new Guid();
        }

        public EPropulsion Propulsion { get => propulsion; }
        protected abstract string Tipo { get; }

        /// <summary>
        /// Retorna la información del vehiculo en formato string.
        /// </summary>
        /// <returns>Una cadena de caracteres con la informacion del vehiculo</returns>
        protected virtual string GetInfo()
        {
            string cadenaRetorno = String.Format("{0} con propulsión a {1}, {2} es AWD, numero de chasis {3}",
                         this.Tipo, this.Propulsion, this.esAWD, this.numeroDeChasis);
            return cadenaRetorno;
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return v1.numeroDeChasis == v2.numeroDeChasis && v1.GetType() == v2.GetType();
        }
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        public override string ToString()
        {
            return this.GetInfo();
        }
    }
}