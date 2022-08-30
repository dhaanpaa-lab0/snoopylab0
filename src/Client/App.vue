<script>
import ClientInputText from './ClientInputText.vue';
import ClientDropdown from "./ClientDropdown";
import ClientExecuteAction from "./ClientExecuteAction";

export default {
  data() {
    return {
      message: "Test",
      srchType: "",
      srchId: "",
      srchName: "",
      srchAddress1: "",
      srchAddress2: "",
      srchCity: "",
      srchState: "",
      srchZip: "",
      searchTypes: [
        {text: "Business Id", value: "srchBusinessId"},
        {text: "Business Name", value: "srchBusinessName"},
        {text: "Business Address", value: "srchBusinessAddress"},
      ]
    };
  },
  methods: {
    searchForm(event) {
      console.log(this.$data)
    }
  },
  components: {ClientExecuteAction, ClientDropdown, ClientInputText}
}
</script>

<template>
  <div>
    <form @submit.prevent="searchForm">
      <client-dropdown field-label="Search Type" v-model="srchType" :options="searchTypes" field-name="srchType"/>
      <div v-if="srchType === 'srchBusinessName'">
        <client-input-text field-label="Name" field-name="srchName" v-model="srchName"/>
      </div>
      <div v-else-if="srchType === 'srchBusinessId'">
        <client-input-text field-label="Id" field-name="srchId" v-model="srchId"/>
      </div>
      <div v-else-if="srchType === 'srchBusinessAddress'">
        <client-input-text field-name="srchAddress1" field-label="Address 1" v-model="srchAddress1"/>
        <client-input-text field-name="srchAddress2" field-label="Address 2" v-model="srchAddress2"/>
        <client-input-text field-name="srchCity" field-label="City" v-model="srchCity"/>
        <client-input-text field-name="srchState" field-label="State" v-model="srchState"/>
        <client-input-text field-name="srchZip" field-label="Zip" v-model="srchZip"/>
      </div>

      <client-execute-action field-label="Actions" action-label="Search" v-if="srchType !== ''"/>
    </form>
  </div>
</template>