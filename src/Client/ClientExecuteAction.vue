<template>
  <div class="mb-3 row">
    <client-form-label :client-component-name="clientComponentName" :field-label="fieldLabel"/>
    <div class="col-sm-10">
      <button type="submit" class="btn btn-primary">{{ actionLabel }}</button>
    </div>
  </div>
</template>

<script>
import {v4 as uuidv4} from "uuid";
import ClientFormLabel from "./ClientFormLabel";

export default {
  name: "ClientExecuteAction",
  components: {ClientFormLabel},
  props: {
    actionLabel: {
      type: String,
      required: true
    },
    fieldLabel: {
      type: String,
      required: true
    }
  },
  data() {

    return {
      clientComponentName: "ea_" + uuidv4().replaceAll("-", "")
    }
  }
}
</script>

