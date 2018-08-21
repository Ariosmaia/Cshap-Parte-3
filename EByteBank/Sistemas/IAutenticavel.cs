using EByteBank.Funcionarios;

namespace EByteBank.Sistemas
{
    public interface IAutenticavel
    {


        bool Autenticar(string senha);
        
    }
}
