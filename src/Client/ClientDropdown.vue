<script>
import {v4 as uuidv4} from 'uuid';
import ClientFormLabel from "./ClientFormLabel";


export default {
  props: {
    fieldName: { type: String, required: true },
    fieldLabel: { type: String, required: true },
    modelValue: String,
    options: { type: Array, required: true }
  },
  emits: [
    'update:modelValue'
  ],
  components: {ClientFormLabel},
  data() {
    return {
      clientComponentName: "dd_" + uuidv4().replaceAll("-", "")
    }
  }
}
</script>

<template>
  <div class="mb-3 row">
    <client-form-label :client-component-name="clientComponentName" :field-label="fieldLabel"/>
    <div class="col-sm-10">
      <select
          :id="clientComponentName"
          :name="fieldName"
          class="form-select"
          :value="modelValue"
          @input="$emit('update:modelValue', $event.target.value)"
        >
        <option value="" disabled selected>Select your option</option>
        <option v-for="option in options" :value="option.value">
          {{ option.text }}
        </option>

      </select>

    </div>
  </div>
</template>