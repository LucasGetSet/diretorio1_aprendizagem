using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Cadastramento
{
    class Personagem
    {
        public string nome;
        public int vida;
        public static int cadastrados = 0;

        public Personagem()
        {
            this.nome = "";
            this.vida = 0;
        }
        public Personagem(string nome, int vida)
        {
            this.nome = nome;
            this.vida = vida;
        }

        
    }
    class Principal
    {   static public int count = 1;
        public static void Cadastro(Personagem p)
        {   
            Console.WriteLine("Escreva o nome do {0}º personagem: ", count);
            p.nome = Console.ReadLine();
            Console.WriteLine("Insira a quantidade de vida: ");
            p.vida = int.Parse(Console.ReadLine());
            count++;
        }

        public static void Selecao(out string choose)
        { 
            
            Console.WriteLine("\n\n[1]. Voltar    [2]. Cadastrar{0} personagem", Principal.count > 1?" outro":"");
            Console.Write(">>> ");
            choose = Console.ReadLine();
        }
        public static void Main()
        {
            string escolha;
            int count = 0;
            Personagem p1 = new Personagem(); Personagem p2 = new Personagem(); Personagem p3 = new Personagem(); 
            Personagem p4 = new Personagem(); Personagem p5 = new Personagem(); Personagem p6 = new Personagem();
            Personagem[] personagens = new Personagem[6]{p1, p2, p3, p4, p5, p6};
            menu:
            Console.Clear();
            Console.Write("Menu:\n[1]. Visualizar Cadastros\n[2]. Cadastrar novo personagem\n\nO que pretende fazer: ");
            escolha = Console.ReadLine();
            Console.Clear();
            if(escolha == "1")
            {
                for(int i = 0; i != 5; i++)
                {   string nome = personagens[i].nome;
                    string vida = personagens[i].vida.ToString();

                    Console.WriteLine("{0}. Nome: {1}  -  Vida: {2}", i+1, nome.Length > 0?nome:"[NÃO CADASTRADO]" , vida == "0"?"[SEM VIDA]":vida);
                }
                Selecao(out escolha);
                if(escolha == "1"){goto menu;}
            }
            else if(escolha == "2")
            {   
                Console.Clear();
                while(escolha == "2")
                {
                Cadastro(personagens[count]);
                count += 1;
                Selecao(out escolha);
                }
                goto menu;
            }
            else{Console.WriteLine("Opção inválida"); goto menu;}
        }   
    }
}