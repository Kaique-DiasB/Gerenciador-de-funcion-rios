using System;
using System.Text.RegularExpressions;

namespace SA02_FenDep
{

	public class CPF
	{
		public string CpfPrincipal;
		public char [] CPFc = new char[11];
		
		public bool Passador( string exemplo)
		{
			CpfPrincipal = exemplo.Replace(",","").Replace(".","").Replace("-","");

			bool Sonumero = 	Regex.IsMatch(CpfPrincipal, "^[0-9]+$");
			
			if(Sonumero && CpfPrincipal.Length==11){
				for (int i = 0; i <CpfPrincipal.Length; i++) {
					CPFc [i]=CpfPrincipal[i];
				}
				return true;
			}
			
			else if (Sonumero && CpfPrincipal.Length<11){
				return false;
			}
			
			else{
				return false;
			}
		}
		
		public bool VerificadorF(string exemplo)
		{
			if (Passador(exemplo)==true)
			{
				
				if (VerificarRepetição(CPFc)==true)
				{
					if (CalculoPrimeiroD(CPFc)==true && CalculoSegundoD(CPFc)==true)
					{
						return true;
					}
					
					else
					{
						return false;
					}
					
				}
				else
				{
					return false;
				}
			}
			else
			{
				return false;
			}
		}
		
		
		
		public bool VerificarRepetição (char[] exemplo){
			
			//Variaveis
			int cont=0;
			for (int i = 0; i <exemplo.Length; i++) {
				if (exemplo[0]==exemplo[i])
				{
					cont++;
				}
			}
			
			//
			if(cont==11){
				return false;
			}
			
			else{
				return true;
			}
		}
		
		public static bool CalculoPrimeiroD (char[] exemplo){
			
			//Declaração de variaveis
			int [] modelo1 = new int [11];
			int soma1=0, resto1=0, posicao10=0, resultado, contador=10;
			
			//Preenchimento do vetor auxiliar e multiplia e soma
			for (int i = 0; i <9; i++) {
				modelo1 [i] = (int)char.GetNumericValue(exemplo[i]);
				soma1+= modelo1[i]*contador;
				contador--;
			}
			
			//Calculo basico do resto da divisão
			resto1=soma1%11;
			posicao10=(int)char.GetNumericValue(exemplo[9]);
			
			//Tratamento do resto da divisão para possível definição do digito
			if (resto1<2) {
				resultado=0;
			}
			else{
				resultado=11-resto1;
				
			}
			
			//Verificação do resto com a posição 10 do CPF, se ambas são iguais
			if(resultado==posicao10){
				return true;
				
			}
			else{
				return false;
				
			}
		}

		public static bool CalculoSegundoD (char[] exemplo){
			//Declaração de variaveis e vetores
			int [] modelo1 = new int [11];
			int soma2=0, resto2=0, posicao11=0, resultado, contador=11;
			
			//Preenchimento do vetor auxiliar e multiplia e soma
			for (int i = 0; i <10; i++) {
				modelo1 [i] = (int)char.GetNumericValue(exemplo[i]);
				soma2+= modelo1[i]*contador;
				contador--;
			}
			
			//Calculo basico do resto da divisão
			resto2=soma2%11;
			posicao11=(int)char.GetNumericValue(exemplo[10]);
			
			
			//Tratamento do resto da divisão para possível definição do digito
			if (resto2<2) {
				resultado=0;
			}
			else{
				resultado=11-resto2;
				
			}
			
			//Verificação do resto com a posição 10 do CPF, se ambas são iguais
			if(resultado==posicao11){
				return true;
				
			}
			else{
				return false;
				
			}
		}
	}
}
