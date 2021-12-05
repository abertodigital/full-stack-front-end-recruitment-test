![N|Solid](https://aberto.com.br/wp-content/uploads/2018/01/aberto_logo_branco.png)

# Teste de recrutamento front + back(full-stack)

<details>
  <summary>Front-end:</summary>
  
  O objetivo do teste é criar um CRUD de herois.

  O código inicial da aplicação pode ter erros que devem ser resolvidas pelo candidato.

  Tela de listagem:
   - Deve ter um filtro por nome;
   - Deve ser possivel excluir um heroi pela tabela.
   Campos obrigatórios da tabela
      - id, nome, poder(valor), pontoFraco(dano)

  Tela de cadastro e edição:
   - Os campos na tela podem ser organizado da forma que quiser;
   - Ao concluir o cadastro, o objeto deve ser guardado em um estado global onde a tela de listagem consiga utilizar;
    campos:
  ```js
     id: string
     name: "string
     origin: DC|Marvel
     power: {
        name: string
        value: int
     }
     weekPoint: {
        weekPointType: Amor|Joia|Lugar|Artefato|Inimigo,
        name: string
        description: string
        damage: int
     }
  ```

  Exemplo de campos preenchidos:
  ```js
  id: "GERADO-AUTOMATICO"
  name: "Homem de Aço"
  origin: DC
  power: {
     name: "Raio laser"
     value: 9999
  }
  pontoFraco: {
     weekPointType: "Artefato"
     name: "Kryptonita"
     description: "Mineral extraterrestre verde e sólido, radioativo, é a única forma de se destruir o Super Homem."
     damage: 999999999
  }
  ```
</details>

<details>
  <summary>Back-end:</summary>
  
  PROBLEMA:
  O objetivo do teste é criar um CRUD de herois com integração back + front.

  Passos:
  - Deve ser feito o front-end que foi detalhado repositorio: LINK
  - Essa API tem apenas o endpoint de CREATE, deve ser feito uma anÃ¡lise no front para ver quais endpoints precisa.
      -  Caso precise de mais endpoints, deve ser criado nessa API e integrado ao front
  - Após o front estar pronto, deve fazer uma integração do front com os endpoints dessa API
      - A integração pode ser feita da maneira que achar melhor.
</details>

## Onde e como desenvolver? 
Pode ser desenvolvido em qualquer IDE.

## Como realizar a entrega do problema? 

Para entregar a resolução do problema, basta subir em um repositório do seu github. Após isso nos envie o link de seu repósitorio. 

## Considerações finais
O teste será avaliado pelo nosso time e um feedback será enviado para o candidato.