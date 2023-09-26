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
</template>

<script>
export default {

  methods: {
    async created() {
      // GET request using fetch with async/await
      const response = await fetch(`https://localhost:9090/api/Contrato/get-contrato-by-id?id=${this.inputValue}`);
      const data = await response.json();
      console.log(data.total);
      console.log(data);      
    },
    mounted() {
      console.log("El componente se ha montado.");
    },
  },

  name: 'HelloWorld',
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
