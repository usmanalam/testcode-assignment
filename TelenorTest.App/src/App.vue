<template>
  <b-container id="app">
    <b-row>
      <b-col>
        <app-header/>
      </b-col>
    </b-row>
    <b-row>
      <b-col>
        <router-view/>
      </b-col>
    </b-row>
    <b-row>
      <b-col>
         <app-footer/>
      </b-col>
     </b-row>
  </b-container>
</template>
<script>
import Navbar from '@/components/Navbar'
import Footer from '@/components/Footer'
export default {
  name: 'App',
  components: {
    'app-header': Navbar,
    'app-footer': Footer
  }
}
</script>
