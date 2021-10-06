<template>
<div class="specs-container">
  <div class="container-fluid">
    <h1>{{ phone.name }} Specs</h1>
    <p>{{ phone.description }}</p>
    <div class="table-responsive">
      <table class="table table-bordered table-hover">
        <tbody>
          <tr>
            <td>Size</td>
            <td>{{ phone.specs[0].size }}</td>
          </tr>
          <tr>
            <td>Weight</td>
            <td>{{ phone.specs[0].weight }}</td>
          </tr>
          <tr>
            <td>Resolution</td>
            <td>{{ phone.specs[0].resolution }}</td>
          </tr>
          <tr>
            <td>Screen</td>
            <td>{{ phone.specs[0].screen }}</td>
          </tr>
          <tr>
            <td>OS</td>
            <td>{{ phone.specs[0].os }}</td>
          </tr>
          <tr>
            <td>Storage</td>
            <td>{{ phone.specs[0].storage }}</td>
          </tr>
          <tr>
            <td>Processor</td>
            <td>{{ phone.specs[0].processor }}</td>
          </tr>
          <tr>
            <td>Connectivity</td>
            <td>{{ phone.specs[0].connectivity }}</td>
          </tr>
        </tbody>
      </table>
    </div>
  </div>
</div>
</template>
<script>
import cellphoneService from '@/services/cellphones.service'
export default {
  name: 'phonespecs',
  data () {
    return {
      id: this.$route.params.id,
      phone: []
    }
  },
  created () {
    cellphoneService.get(this.id).then((response) => {
      this.phone = response.data
    }).catch((error) => {
      console.log(error.response.data)
    })
  }
}
</script>

<style scoped>
.specs-container {
    position: relative;
    top:30px;
}
</style>
