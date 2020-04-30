<template xmlns:v-slot="http://www.w3.org/1999/XSL/Transform">
    <div>
        <v-data-table
                :headers="headers"
                :items="podds"
                :items-per-page="7"
                :height="height"
                item-key="name"
                class="elevation-0"
                fixedheader="true"
                v-scroll
        >
            <template v-slot:item.actions="{ item }">
                <v-icon v-model="item.actions">mdi-pencil</v-icon>
                <v-icon>mdi-format-list-bulleted</v-icon>
                <v-icon>mdi-content-copy</v-icon>
                <v-icon >mdi-map-outline</v-icon>
            </template>
            <template v-slot:footer>
                <td :colspan="headers.length">
                    <p>Количество документов: 115</p>
                </td>
            </template>

        </v-data-table>



        <v-footer  fixed  width="80%" color="#FFFFFF">
            <v-btn class="float-left primary">Создать ПОДД</v-btn>
        </v-footer>
    </div>


</template>


<script>
    export default {
        data () {
            return {
                height: "100%",
                headers: [
                    {
                        text: 'Документ',
                        align: 'start',
                        value: 'document',
                    },
                    { text: 'Наименование документа', value: 'name' },
                    { text: 'Наименование заказчика', value: 'ownername' },
                    { text: 'Наименование разработчика', value: 'devname' },
                    { text: 'Дата утверждения', value: 'approvedate' },
                    { text: 'Дата регистрации в системе', value: 'regdate' },
                    { text: 'Срок действия документа', value: 'stopdate' },
                    { text: 'Действия', value: 'actions', sortable: false },
                    { text: 'Федеральный округ', value: 'feddistrict' },
                    { text: 'Субъект РФ', value: 'region' },
                    { text: 'Муниципальное образование', value: 'municipal' },
                ],
                podds: [
                    {
                        document: 'ПОДД',
                        name: 'ПОДД по улице придородного графа',
                        ownername: 'Администрация',
                        devname: 'ООО Разрабик',
                        approvedate: '2020-03-01',
                        regdate: '2020-03-01',
                        stopdate: '2023-03-01',
                        feddistrict: 'Центральный Федеральный округ',
                        region: 'Московская область',
                        municipal: 'Мытищи (Московская область)',
                    },
                    {
                        document: 'ПОДД',
                        name: 'ПОДД по улице придородного графа',
                        ownername: 'Администрация',
                        devname: 'ООО Разрабик',
                        approvedate: '2020-03-01',
                        regdate: '2020-03-01',
                        stopdate: '2023-03-01',
                        feddistrict: 'Центральный Федеральный округ',
                        region: 'Московская область',
                        municipal: 'Мытищи (Московская область)',
                    },
                    {
                        document: 'ПОДД',
                        name: 'ПОДД по улице придородного графа',
                        ownername: 'Администрация',
                        devname: 'ООО Разрабик',
                        approvedate: '2020-03-01',
                        regdate: '2020-03-01',
                        stopdate: '2023-03-01',
                        feddistrict: 'Центральный Федеральный округ',
                        region: 'Московская область',
                        municipal: 'Мытищи (Московская область)',
                    },
                    {
                        document: 'ПОДД',
                        name: 'ПОДД по улице придородного графа',
                        ownername: 'Администрация',
                        devname: 'ООО Разрабик',
                        approvedate: '2020-03-01',
                        regdate: '2020-03-01',
                        stopdate: '2023-03-01',
                        feddistrict: 'Центральный Федеральный округ',
                        region: 'Московская область',
                        municipal: 'Мытищи (Московская область)',
                    },
                    {
                        document: 'ПОДД',
                        name: 'ПОДД по улице придородного графа',
                        ownername: 'Администрация',
                        devname: 'ООО Разрабик',
                        approvedate: '2020-03-01',
                        regdate: '2020-03-01',
                        stopdate: '2023-03-01',
                        feddistrict: 'Центральный Федеральный округ',
                        region: 'Московская область',
                        municipal: 'Мытищи (Московская область)',
                    },
                    {
                        document: 'ПОДД',
                        name: 'ПОДД по улице придородного графа',
                        ownername: 'Администрация',
                        devname: 'ООО Разрабик',
                        approvedate: '2020-03-01',
                        regdate: '2020-03-01',
                        stopdate: '2023-03-01',
                        feddistrict: 'Центральный Федеральный округ',
                        region: 'Московская область',
                        municipal: 'Мытищи (Московская область)',
                    },
                    {
                        document: 'ПОДД',
                        name: 'ПОДД по улице придородного графа',
                        ownername: 'Администрация',
                        devname: 'ООО Разрабик',
                        approvedate: '2020-03-01',
                        regdate: '2020-03-01',
                        stopdate: '2023-03-01',
                        feddistrict: 'Центральный Федеральный округ',
                        region: 'Московская область',
                        municipal: 'Мытищи (Московская область)',
                    },
                    {
                        document: 'ПОДД',
                        name: 'ПОДД по улице придородного графа',
                        ownername: 'Администрация',
                        devname: 'ООО Разрабик',
                        approvedate: '2020-03-01',
                        regdate: '2020-03-01',
                        stopdate: '2023-03-01',
                        feddistrict: 'Центральный Федеральный округ',
                        region: 'Московская область',
                        municipal: 'Мытищи (Московская область)',
                    },
                    {
                        document: 'ПОДД',
                        name: 'ПОДД по улице придородного графа',
                        ownername: 'Администрация',
                        devname: 'ООО Разрабик',
                        approvedate: '2020-03-01',
                        regdate: '2020-03-01',
                        stopdate: '2023-03-01',
                        feddistrict: 'Центральный Федеральный округ',
                        region: 'Московская область',
                        municipal: 'Мытищи (Московская область)',
                    },
                    {
                        document: 'ПОДД',
                        name: 'ПОДД по улице придородного графа',
                        ownername: 'Администрация',
                        devname: 'ООО Разрабик',
                        approvedate: '2020-03-01',
                        regdate: '2020-03-01',
                        stopdate: '2023-03-01',
                        feddistrict: 'Центральный Федеральный округ',
                        region: 'Московская область',
                        municipal: 'Мытищи (Московская область)',
                    },{
                        document: 'ПОДД',
                        name: 'ПОДД по улице придородного графа',
                        ownername: 'Администрация',
                        devname: 'ООО Разрабик',
                        approvedate: '2020-03-01',
                        regdate: '2020-03-01',
                        stopdate: '2023-03-01',
                        feddistrict: 'Центральный Федеральный округ',
                        region: 'Московская область',
                        municipal: 'Мытищи (Московская область)',
                    },{
                        document: 'ПОДД',
                        name: 'ПОДД по улице придородного графа',
                        ownername: 'Администрация',
                        devname: 'ООО Разрабик',
                        approvedate: '2020-03-01',
                        regdate: '2020-03-01',
                        stopdate: '2023-03-01',
                        feddistrict: 'Центральный Федеральный округ',
                        region: 'Московская область',
                        municipal: 'Мытищи (Московская область)',
                    },{
                        document: 'ПОДД',
                        name: 'ПОДД по улице придородного графа',
                        ownername: 'Администрация',
                        devname: 'ООО Разрабик',
                        approvedate: '2020-03-01',
                        regdate: '2020-03-01',
                        stopdate: '2023-03-01',
                        feddistrict: 'Центральный Федеральный округ',
                        region: 'Московская область',
                        municipal: 'Мытищи (Московская область)',
                    },{
                        document: 'ПОДД',
                        name: 'ПОДД по улице придородного графа',
                        ownername: 'Администрация',
                        devname: 'ООО Разрабик',
                        approvedate: '2020-03-01',
                        regdate: '2020-03-01',
                        stopdate: '2023-03-01',
                        feddistrict: 'Центральный Федеральный округ',
                        region: 'Московская область',
                        municipal: 'Мытищи (Московская область)',
                    },

                ],

            }
        },
        methods: {

        }
    }
</script>

<style scoped>

</style>