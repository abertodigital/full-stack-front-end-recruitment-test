**Teste front-end**
O objetivo do teste é criar um CRUD de herois.

O código inicial da aplicação pode ter erros que devem ser resolvidas pelo candidato.

Tela de listagem:
 - Deve ter um filtro por nome;
 - Deve ser possivel excluir um heroi pela tabela.
 Campos obrigatorios da tabela:te
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