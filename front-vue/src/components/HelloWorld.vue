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
              <div class="col border border-dark" v-if="this.curso[0]"> {{this.curso[0].courseCode}} </div>
              <div class="col border border-dark" v-if="this.curso[0]"> {{this.curso[0].fechaAlta}} </div>
              <div class="col border border-dark" v-if="this.curso[0]"> {{this.curso[0].colegioNombre}} </div>
              <div class="col border border-dark" v-if="this.curso[0]"> {{this.curso[0].colegioNivel}} </div>
              <div class="col border border-dark" v-if="this.curso[0]"> {{this.curso[0].colegioCurso}} </div>
              <div class="col border border-dark" v-if="this.curso[0]"> {{this.curso[0].colegioLocalidad}} </div>
              <div class="col border border-dark" v-if="this.curso[0]">
                <div class="col border border-dark" v-for="(contrato,index) in this.curso[0].contrato" :key="index">
                  Cantidad: {{ this.curso[0].cantidadEgresado }}
                  Articulo: {{ contrato.producto.nombre }}
                  Precio Unitario: {{ contrato.producto.precio }}
                  Precio Totales: {{ this.PreciosTotales[index] }}
              </div>
            </div>
            <div class="col border border-dark" v-if="this.curso[0]"> {{this.curso[0].total}} </div>
            <div class="col border border-dark" v-if="this.curso[0]"> {{this.curso[0].fechaEntrega}} </div>
          </div>
    </div>
</template>

<script>
import axios from 'axios'
export default {
  name: 'HelloWorld',
  data(){    
    return{
      PreciosTotales:[],
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
      axios.get(`https://localhost:9090/api/Curso/get-curso-by-id?id=${this.inputValue}`)  
        .then((response)=>{
          this.curso = response.data;
          console.log(this.curso[0])
          this.getTotal()          
        })
        .catch((error) =>{
          console.log(error)
        })
    },
    getTotal(){
      for(var x = 0; x < this.curso[0].contrato.length; x++){
        this.PreciosTotales[x] = this.curso[0].cantidadEgresado * this.curso[0].contrato[x].producto.precio
        console.log(this.PreciosTotales[x])
      }
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
