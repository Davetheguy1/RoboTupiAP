# RoboTupiAP
## Descri��o
Uma simula��o em que o usu�rio pode movimentar dois rob�s em um grid determinado pelo usu�rio, feito para a Academia do Programador.
## Funcionalidade
Ap�s a determina��o do grid, o usu�rio poder� "soltar" o primeiro rob� em uma posi��o espec�fica (consultar na aba "Como Usar") com uma string de comandos, ap�s isso, ele poder� utilizar-se de outra string de comando para execultar uma s�rie de outros movimentos dentro do plano(consultar na aba "Como Usar"). A Utiliza��o dos rob�s ocorre de forma sequencial, ou seja, apenas ap�s as duas strings de comandos do primeiro rob� serem escritas e validas � que o segundo rob� ser� ativado e poder� execultar suas strings de comando.
## Como Usar
### Grid:
O Usu�rio pode escolher (basicamente), qualquer valor para ambas as dimens�es do grid, portanto, n�o � recomendado utilizar medidas mutios grandes, uma vez que a monitora��o de certas propriedades da aplica��o (movimento, limite do grid),
caso o usu�rio declare o ponto de partida do rob� fora dos param�tros do grid, ou sua segunda string de comandos passe de algum limite, o usu�rio ser� colocado na �ltima coordenada poss�vel (ex. em um grid 5,5, um comando de lan�amento 3,6,N teria resultado 3,5,N)
o grid n�o pode ser mudado durante a expedi��o de nenhum dos dois rob�s.
### Strings de Comando:
Ao iniciar a expedi��o, o usu�rio ter� de escrever uma string no formato (x,y,d), com x sendo a coordenada no eixo horizontal, y a coordenada do eixo vertical, e d sendo a dire��o em que o rob� estara virado para com N sendo Norte, L sendo Leste, S sendo Sul e O sendo Oeste, � recomendado que o usu�rio apenas informe uma letra mai�scula para a dire��o, apesar dos nomes das dire��es e letras min�sculas tamb�m poderem ser utilizadas.

Ap�s o lan�amento do rob�, o Usu�rio ter� de escrever uma nova string de comandos, agora podendo utilizar as letras "M","D" e "E" o comando M movimenta o rob� um espa�o para a dire��o que ele estiver olhando, j� os comandos E e D viram o rob� ou para a esquerda ou para a direita, respectivamente, sem se movimentar para outro espa�o do grid no processo. Essa string de comando n�o possue um limite de instru��es, portanto, assim como no grid, � importante n�o utilizar comandos muito grandes, como forma de inspecionar e certificar que o rob�e est� de fato seguindo suas ordems corretamente.
## Cr�ditos
Programa feito por Danilo Cenci (https://github.com/Davetheguy1)

Agradecimentos �

Tiago Santini, da Academia do Programador (https://github.com/tiagosantini)

Alexandre Rech, da Academia do Programador (https://github.com/alexandre-rech-lages)