# RoboTupiAP
## Descrição
Uma simulação em que o usuário pode movimentar dois robôs em um grid determinado pelo próprio usuário, feito para a Academia do Programador.
## Funcionalidade
Após a determinação do grid, o usuário poderá "soltar" o primeiro robô em uma posição específica (consultar na aba "Como Usar") com uma string de comandos, após isso, ele poderá utilizar-se de outra string de comando para execultar uma série de outros movimentos dentro do plano(consultar na aba "Como Usar"). A Utilização dos robôs ocorre de forma sequencial, ou seja, apenas após as duas strings de comandos do primeiro robô serem escritas e validadas é que o segundo robô será ativado e poderá execultar suas strings de comando.
## Como Usar
### Grid:
O Usuário pode escolher (basicamente), qualquer valor para ambas as dimensões do grid, portanto, não é recomendado utilizar medidas muitos grandes, uma vez que a monitoração de certas propriedades da aplicação (movimento, limite do grid) pode ser dificultada,
caso o usuário declare o ponto de partida do robô fora dos paramêtros do grid, ou sua segunda string de comandos passe de algum limite, o usuário será colocado na última coordenada possível (ex. em um grid 5,5, um comando de lançamento 3,6,N teria resultado 3,5,N)
o grid não pode ser mudado durante a expedição de nenhum dos dois robôs.
### Strings de Comando:
Ao iniciar a expedição, o usuário terá de escrever uma string no formato (x,y,d), com x sendo a coordenada no eixo horizontal, y a coordenada do eixo vertical, e d sendo a direção em que o robô estara virado para, com N sendo Norte, L sendo Leste, S sendo Sul e O sendo Oeste, é recomendado que o usuário apenas informe uma letra maiúscula para a direção, apesar dos nomes inteiros das direções e letras minúsculas serem também convertidas para uso.

Após o lançamento do robô, o Usuário terá de escrever uma nova string de comandos, agora utilizando as letras "M","D" e "E", o comando "M" movimenta o robô uma unidade de espaço para a direção que ele estiver olhando, já os comandos "E" e "D" viram o robô ou para a esquerda ou para a direita, respectivamente, sem se movimentar para outro espaço do grid no processo. Essa string de comando não possue um limite de instruções, portanto, assim como no grid, é importante não utilizar comandos muito grandes, como forma de inspecionar e certificar que o robô está de fato seguindo suas ordems corretamente.
## Créditos
Programa feito por Danilo Cenci (https://github.com/Davetheguy1)

Agradecimentos à

Tiago Santini, da Academia do Programador (https://github.com/tiagosantini)

Alexandre Rech, da Academia do Programador (https://github.com/alexandre-rech-lages)
