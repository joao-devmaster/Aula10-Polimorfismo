namespace Aula10POO
{
    public class Messi : Jogador
    {
        public override void driblar(){
            
            //base= aproveitar as açoes do metodo pai
            base.driblar();

            System.Console.WriteLine("o messi também pode driblar 30% mais rapido");

        }

    }
}