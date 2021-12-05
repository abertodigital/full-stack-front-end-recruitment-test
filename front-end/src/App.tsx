import { push } from 'connected-react-router';
import { useDispatch } from 'react-redux';
import './App.css';

function App() {
  var dispatch = useDispatch()
  return (
    <div className="App">
      <button onClick={() => {dispatch(push('página-2'))}}>Ir para página 2</button>
      <h1>Bem vindo ao teste!</h1>
      <h2>Segue oque precisa ser feito:</h2>
      <h3>
      CRUD de super herois <br/>
      Tela de listagem:<br/>
         - Deve ter um filtro por nome<br/>
         - Deve ser possivel excluir um heroi pela tabela<br/>
         Campos da tabela:<br/>
            id, nome, poder(valor), pontoFraco(dano)<br/>
            <br/>
      Tela de cadastro e edição:<br/>
         - Os campos na tela podem ser organizado da forma que quiser<br/>
         - Ao concluir o cadastro, deve ser guardado em um estado global onde a tela de listagem consegue utilizar<br/>
         campos:<br/>
            id: string<br/>
            nome: string + obrigatorio<br/>
            origem: DC|Marvel + obrigatorio<br/>
            poder: {'{'}<br/>
               nome: string<br/>
               valor: int + obrigatorio<br/>
            {'}'}<br/>
            pontoFraco: {'{'}<br/>
               tipoDoPontoFraco: Amor|Joia|Lugar|Artefato|Inimigo, + obrigatorio<br/>
               nome: string + obrigatorio<br/>
               description: string<br/>
               dano: int + obrigatorio<br/>
            {'}'}<br/>
            <br/>
            Exemplo com campos preenchidos:<br/>
            id: "GERADO-AUTOMATICO"<br/>
            nome: "Homem de Aço"<br/>
            origem: DC<br/>
            poder: {'{'}<br/>
               nome: "Raio laser"<br/>
               valor: 9999<br/>
            {'}'}<br/>
            pontoFraco: {'{'}<br/>
               tipoDoPontoFraco: "Artefato"<br/>
               nome: "Kryptonita"<br/>
               description: "Mineral extraterrestre verde e sólido, radioativo, é a única forma de se destruir o Super Homem."<br/>
               dano: 999999999<br/>
            {'}'}<br/>
      </h3>
    </div>
  );
}

export default App;
