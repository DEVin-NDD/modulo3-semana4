namespace modulo3_semana04.PattnerSingleton
{
    /// <summary>
    /// Sealed evita que a classe seja HERDADA em outra classe qualquer
    /// </summary>
    public sealed class Singleton
    {
        private Singleton() { }

        private static Singleton _intance;

        public static Singleton GetInstance()
        {
            if (_intance == null)
            {
                _intance = new Singleton();
            }

            return _intance;
        }

        public string DevolveHoraEmString()
        {
            return $"Data e hora de POA ${DateTime.Now}";
        }

    }
}
