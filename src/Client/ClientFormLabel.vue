<template>
  <label class="col-sm-2 col-form-label text-end"
         :for="clientComponentName">{{ fieldLabel }}:</label>
</template>
<script>
export default {
  name: 'client-form-label',
  props: {
    clientComponentName: {},
    fieldLabel: {}
  }
}
</script>
