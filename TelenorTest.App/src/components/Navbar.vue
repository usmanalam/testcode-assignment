<template>
  <b-navbar toggleable="md" type="dark" variant="info">
    <b-navbar-toggle target="nav_collapse"></b-navbar-toggle>
    <b-navbar-brand :to="{ name: 'CellPhones' }">CellPhones</b-navbar-brand>
  </b-navbar>
</template>
<script>
export default {
  name: 'Navbar'
}
</script>
