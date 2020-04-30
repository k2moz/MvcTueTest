<template>
    <v-simple-table
            :dense="dense"
            :fixed-header="fixedHeader"
            :height="height"
            >
        <template v-slot:default>
            <thead>
            <tr>
                <th class="text-left">Документ</th>
                <th class="text-left">Наименование</th>
                <th class="text-left">Наименование заказчика</th>
                <th class="text-left">Наименование разработчика</th>
                <th class="text-left">Дата утверждения</th>
                <th class="text-left">Дата регистрации в системе</th>
                <th class="text-left">Срок действия документа</th>
                <th class="text-left">Действия</th>
                <th class="text-left">Федеральный округ</th>
                <th class="text-left">Субъект РФ</th>
                <th class="text-left">Муниципальное образование</th>
            </tr>
            </thead>
            <tbody>
            <tr v-for="ksodd in ksodds" :key="ksodd.name">
                <td>{{ ksodd.document }}</td>
                <td>{{ ksodd.name }}</td>
                <td>{{ ksodd.ownername }}</td>
                <td>{{ ksodd.devname }}</td>
                <td>{{ ksodd.dateapprove }}</td>
                <td>{{ ksodd.datereg }}</td>
                <td>{{ ksodd.deadlinedoc }}</td>
                <td>
                    <v-icon>{{ksodd.actions}}</v-icon>
                </td>
                <td>{{ ksodd.feddistrict }}</td>
                <td>{{ ksodd.region }}</td>
                <td>{{ ksodd.municipal }}</td>
            </tr>
            </tbody>
            <v-footer fixed width="80%" class="elevation-1" color="#FFFFFF">
                <v-btn class="primary" @click="ksoddVisible =!ksoddVisible">Создать КСОДД</v-btn>
            </v-footer>
        </template>
    </v-simple-table>
</template>

<script>
    export default {
        data () {
            return {
                data () {
                    return {
                        dense: false,
                        fixedHeader: true,
                        height: 300,
                        ksoddVisible: false,
                    }
                },
                ksodds: [
                    {
                        document: 'КСОДД',
                        name: 'КСОДД по агломерации',
                        ownername: 'Администрация',
                        devname: 'ООО Рога и копыта',
                        dateapprove: '2020-02-01',
                        datereg: '2020-02-01',
                        deadlinedoc: '2035-02-01',
                        actions: ['mdi-pencil', 'mdi-format-list-bulleted', 'mdi-content-copy', 'mdi-map-outline'],
                        feddistrict: 'Приволжский Федеральный округ',
                        region: 'Республика Чувашия',
                        municipal: 'Городской округ Город Чебоксары',
                    },
                    {
                        document: 'КСОДД',
                        name: 'КСОДД по агломерации',
                        ownername: 'Администрация',
                        devname: 'ООО Рога и копыта',
                        dateapprove: '2020-02-01',
                        datereg: '2020-02-01',
                        deadlinedoc: '2035-02-01',
                        feddistrict: 'Приволжский Федеральный округ',
                        region: 'Республика Чувашия',
                        municipal: 'Городской округ Город Чебоксары',
                    },
                    {
                        document: 'КСОДД',
                        name: 'КСОДД по агломерации',
                        ownername: 'Администрация',
                        devname: 'ООО Рога и копыта',
                        dateapprove: '2020-02-01',
                        datereg: '2020-02-01',
                        deadlinedoc: '2035-02-01',
                        feddistrict: 'Приволжский Федеральный округ',
                        region: 'Республика Чувашия',
                        municipal: 'Городской округ Город Чебоксары',
                    },
                    {
                        document: 'КСОДД',
                        name: 'КСОДД по агломерации',
                        ownername: 'Администрация',
                        devname: 'ООО Рога и копыта',
                        dateapprove: '2020-02-01',
                        datereg: '2020-02-01',
                        deadlinedoc: '2035-02-01',
                        feddistrict: 'Приволжский Федеральный округ',
                        region: 'Республика Чувашия',
                        municipal: 'Городской округ Город Чебоксары',
                    },
                    {
                        document: 'КСОДД',
                        name: 'КСОДД по агломерации',
                        ownername: 'Администрация',
                        devname: 'ООО Рога и копыта',
                        dateapprove: '2020-02-01',
                        datereg: '2020-02-01',
                        deadlinedoc: '2035-02-01',
                        feddistrict: 'Приволжский Федеральный округ',
                        region: 'Республика Чувашия',
                        municipal: 'Городской округ Город Чебоксары',
                    },{
                        document: 'КСОДД',
                        name: 'КСОДД по агломерации',
                        ownername: 'Администрация',
                        devname: 'ООО Рога и копыта',
                        dateapprove: '2020-02-01',
                        datereg: '2020-02-01',
                        deadlinedoc: '2035-02-01',
                        feddistrict: 'Приволжский Федеральный округ',
                        region: 'Республика Чувашия',
                        municipal: 'Городской округ Город Чебоксары',
                    },{
                        document: 'КСОДД',
                        name: 'КСОДД по агломерации',
                        ownername: 'Администрация',
                        devname: 'ООО Рога и копыта',
                        dateapprove: '2020-02-01',
                        datereg: '2020-02-01',
                        deadlinedoc: '2035-02-01',
                        feddistrict: 'Приволжский Федеральный округ',
                        region: 'Республика Чувашия',
                        municipal: 'Городской округ Город Чебоксары',
                    },{
                        document: 'КСОДД',
                        name: 'КСОДД по агломерации',
                        ownername: 'Администрация',
                        devname: 'ООО Рога и копыта',
                        dateapprove: '2020-02-01',
                        datereg: '2020-02-01',
                        deadlinedoc: '2035-02-01',
                        feddistrict: 'Приволжский Федеральный округ',
                        region: 'Республика Чувашия',
                        municipal: 'Городской округ Город Чебоксары',
                    },{
                        document: 'КСОДД',
                        name: 'КСОДД по агломерации',
                        ownername: 'Администрация',
                        devname: 'ООО Рога и копыта',
                        dateapprove: '2020-02-01',
                        datereg: '2020-02-01',
                        deadlinedoc: '2035-02-01',
                        feddistrict: 'Приволжский Федеральный округ',
                        region: 'Республика Чувашия',
                        municipal: 'Городской округ Город Чебоксары',
                    },{
                        document: 'КСОДД',
                        name: 'КСОДД по агломерации',
                        ownername: 'Администрация',
                        devname: 'ООО Рога и копыта',
                        dateapprove: '2020-02-01',
                        datereg: '2020-02-01',
                        deadlinedoc: '2035-02-01',
                        feddistrict: 'Приволжский Федеральный округ',
                        region: 'Республика Чувашия',
                        municipal: 'Городской округ Город Чебоксары',
                    },{
                        document: 'КСОДД',
                        name: 'КСОДД по агломерации',
                        ownername: 'Администрация',
                        devname: 'ООО Рога и копыта',
                        dateapprove: '2020-02-01',
                        datereg: '2020-02-01',
                        deadlinedoc: '2035-02-01',
                        feddistrict: 'Приволжский Федеральный округ',
                        region: 'Республика Чувашия',
                        municipal: 'Городской округ Город Чебоксары',
                    },{
                        document: 'КСОДД',
                        name: 'КСОДД по агломерации',
                        ownername: 'Администрация',
                        devname: 'ООО Рога и копыта',
                        dateapprove: '2020-02-01',
                        datereg: '2020-02-01',
                        deadlinedoc: '2035-02-01',
                        feddistrict: 'Приволжский Федеральный округ',
                        region: 'Республика Чувашия',
                        municipal: 'Городской округ Город Чебоксары',
                    },{
                        document: 'КСОДД',
                        name: 'КСОДД по агломерации',
                        ownername: 'Администрация',
                        devname: 'ООО Рога и копыта',
                        dateapprove: '2020-02-01',
                        datereg: '2020-02-01',
                        deadlinedoc: '2035-02-01',
                        feddistrict: 'Приволжский Федеральный округ',
                        region: 'Республика Чувашия',
                        municipal: 'Городской округ Город Чебоксары',
                    },
                ]

            }
        }
    }
</script>

<style lang="css" scoped>

</style>