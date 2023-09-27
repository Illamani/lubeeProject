<template>
  <div>
    <h1>{{ msg }}</h1>
  </div>
  <div>
    <input type="number" inputmode="numeric" placeholder="Ingresar Id" v-model="inputValue">
  </div>
  <div>
    <button class="btn btn-primary" @click="created">Buscar Curso</button>
  </div>
  <!--table table-dark-->
  <div class="container-fluid ">
        <h1 class="text-center display-9">Tabla Cursos</h1>  
        <div class="row border border-dark bg-primary " id="heading">
            <div class="col border border-dark">Código de curso</div>
            <div class="col border border-dark">Fecha de alta</div>
            <div class="col border border-dark">Colegio</div>
            <div class="col border border-dark">Nivel</div>
            <div class="col border border-dark">Curso</div>
            <div class="col border border-dark">Localidad</div>
            <div class="col border border-dark">Pedido</div>
            <div class="col border border-dark">Total</div>
            <div class="col border border-dark">Fecha de entrega</div>
        </div>
  
        <div class="row border border-dark ">          
              <div class="col border border-dark" v-if="this.curso"> {{this.curso.courseCode}} </div>
              <div class="col border border-dark" v-if="this.curso"> {{this.curso.fechaAlta}} </div>
              <div class="col border border-dark" v-if="this.curso"> {{this.curso.colegioNombre}} </div>
              <div class="col border border-dark" v-if="this.curso"> {{this.curso.colegioNivel}} </div>
              <div class="col border border-dark" v-if="this.curso"> {{this.curso.colegioCurso}} </div>
              <div class="col border border-dark" v-if="this.curso"> {{this.curso.colegioLocalidad}} </div>
              <div class="col border border-dark" v-if="this.curso">
                <div class="col border border-dark" v-for="index in 3" :key="index">
                  {{index}}
              </div>
            </div>
            <div class="col border border-dark" v-if="this.curso"> {{this.curso.total}} </div>
            <div class="col border border-dark" v-if="this.curso"> {{this.curso.fechaEntrega}} </div>
          </div>
    </div>
</template>

<script>
import axios from 'axios'
export default {
  name: 'HelloWorld',
  data(){    
    return{
      inputValue: '',
      contrato: {
      ContractId: null,
      ItemId: null,
      CreatedDate: null,
      UpdateDate: null,
      Enabled: false,
      Deleted: false,
      CreatedBy: null
      },
      curso: {
        CourseCode: null,
        FechaAlta: null,
        Estado: null,
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
          console.log(this.producto.nombre)
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

<style scoped>
input[type="number"]::-webkit-inner-spin-button,
input[type="number"]::-webkit-outer-spin-button {
  -webkit-appearance: none;
  appearance: none;
  margin: 0;
}
body {
    background-color: #ffcc00; 
}
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
