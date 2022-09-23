namespace modulo3_semana04.PatternAdpter
{
    public class AdapterWithInterface : ITarget
    {
        private readonly AdapteNothingInterfaceLagacy adapteNothingInterfaceLagacy;

        public AdapterWithInterface(AdapteNothingInterfaceLagacy adapteNothingInterfaceLagacy)
        {
            this.adapteNothingInterfaceLagacy = adapteNothingInterfaceLagacy;
        }

        public string GetRequest()
        {
            return $@"Classe {nameof(AdapterWithInterface)} 
- Metodo {nameof(GetRequest)} 
- Interface ${nameof(ITarget)}
- Metodo da Classe Passada no Construtor ${adapteNothingInterfaceLagacy.GetSpecificRequest()}";
        }
    }
}
