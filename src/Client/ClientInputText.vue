<script>
import {v4 as uuidv4} from 'uuid';
import ClientFormLabel from "./ClientFormLabel";


export default {
  props: {
    fieldName: {type: String, required: true},
    fieldLabel: {type: String, required: true},
    modelValue: String
  },
  components: {ClientFormLabel},
  emits: [
    'update:modelValue'
  ],
  data() {
    return {
      clientComponentName: "textinp_" + uuidv4().replaceAll("-", "")
    }
  }
}
</script>

<template>
  <div class="mb-3 row">
    <client-form-label :client-component-name="clientComponentName" :field-label="fieldLabel"/>
    <div class="col-sm-10">
      <input
          :id="clientComponentName"
          :name="fieldName"
          class="form-control"
          :value="modelValue"
          @input="$emit('update:modelValue', $event.target.value)"/>
    </div>
  </div>
</template>