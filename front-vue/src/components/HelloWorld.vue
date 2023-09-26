<template>
  <div class="hello">
    <h1>{{ msg }}</h1>
    <p>
      For a guide and recipes on how to configure / customize this project,<br>
      check out the
      <a href="https://cli.vuejs.org" target="_blank" rel="noopener">vue-cli documentation</a>.
    </p>
  </div>
  <div>
    <input type="number" placeholder="Ingresar Id" v-model="inputValue">
  </div>
  <div>
    <button @click="created">Registrar mensaje</button>
  </div>
  <div>
    {{ this.contrato.producto }}
  </div>
</template>

<script>
import axios from 'axios'
export default {
  name: 'HelloWorld',
  data(){    
    return{
      contrato: {
      Id: null,
      ContractId: null,
      ItemId: null,
      CreatedDate: null,
      UpdateDate: null,
      Enabled: false,
      Deleted: false,
      CreatedBy: null
      },
      curso: {
        Id: null,
        CourseCode: null,
        FechaAlta: null,
        Estaod: null,
        CantidadEgresado: null,
        FechaEntrega: null,
        MediaEntrega: null,
        Vendedor: null,
        ColegioNivel: null,
        ColegioNombre: null,
        ColegioCurso: null,
        ColegioLocalidad: null,
        Comision: null,
        Total: null,
      },
      producto: {
        Id: null,
        Nombre: null,
        Precio: null,
      }
    }
  },
  methods: {
    async created() {    
      axios.get(`https://localhost:9090/api/Contrato/get-contrato-by-id?id=${this.inputValue}`)  
        .then((response)=>{
          this.contrato = response.data;
          this.curso = this.contrato.curso;
          this.producto = this.contrato.producto;
          console.log(this.contrato)
          console.log(this.curso)
          console.log(this.producto)
        })
        .catch((error) =>{
          console.log(error)
        })
    }
  },
  props: {
    msg: String
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
h3 {
  margin: 40px 0 0;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>
