<template>
    <v-simple-table fixed-header>
        <template v-slot:default>
            <thead>
            <tr>
                <th class="text-left">
                    Идентификатор маршрута
                    <v-btn text small>
                        <v-icon x-small class="mx-1" right>mdi-filter</v-icon>
                    </v-btn>
                </th>
                <th class="text-left">Идентификатор опорного участка
                    <v-btn text small>
                        <v-icon x-small class="mx-1" right>mdi-filter</v-icon>
                    </v-btn>
                </th>
                <th class="text-left">Дата обследования
                    <v-btn text small>
                        <v-icon x-small class="mx-1" right>mdi-filter</v-icon>
                    </v-btn>
                </th>
                <th class="text-left">Дата регистрации в системе
                    <v-btn text small>
                        <v-icon x-small class="mx-1" right>mdi-filter</v-icon>
                    </v-btn>
                </th>
                <th class="text-left">Действия</th>
                <th class="text-left">Федеральный округ
                    <v-btn text small>
                        <v-icon x-small class="mx-1" right>mdi-filter</v-icon>
                    </v-btn>
                </th>
                <th class="text-left">Субъект РФ
                    <v-btn text small>
                        <v-icon x-small class="mx-1" right>mdi-filter</v-icon>
                    </v-btn>
                </th>
                <th class="text-left">Муниципальное образование
                    <v-btn text small>
                        <v-icon x-small class="mx-1" right>mdi-filter</v-icon>
                    </v-btn>
                </th>
            </tr>
            </thead>
            <tbody>
            <tr v-for="kts in ktsdocs" :key="kts.ref_section_id">
                <td>{{ kts.id_route }}</td>
                <td>{{ kts.ref_section_id }}</td>
                <td>{{ kts.research_date }}</td>
                <td>{{ kts.reg_date }}</td>
                <td>
                    <v-icon>mdi-pencil</v-icon>
                    <v-icon>mdi-format-list-bulleted</v-icon>
                    <!--              <v-icon>mdi-content-copy</v-icon>-->
                    <v-icon>mdi-map-outline</v-icon>
                </td>
                <td>{{ kts.feddistrict }}</td>
                <td>{{ kts.region }}</td>
                <td>{{ kts.municipal }}</td>
            </tr>
            </tbody>
            <v-footer  fixed  width="80%" color="#FFFFFF">
                <v-btn class="float-right primary">Создать результаты обследования</v-btn>
            </v-footer>
        </template>
    </v-simple-table>
</template>

<script>
    export default {
        data () {
            return {
                ktsdocs: [
                    {
                        id_route: '675',
                        ref_section_id: '12345',
                        research_date: '2020-02-01',
                        reg_date: '2020-03-11',
                        feddistrict: 'Приволжский Федеральный округ',
                        region: 'Республика Чувашия',
                        municipal: 'Городской округ Город Чебоксары',
                    },
                    {
                        id_route: '675',
                        ref_section_id: '435435',
                        research_date: '2020-02-01',
                        reg_date: '2020-03-11',
                        feddistrict: 'Приволжский Федеральный округ',
                        region: 'Республика Чувашия',
                        municipal: 'Городской округ Город Чебоксары',
                    },
                    {
                        id_route: '675',
                        ref_section_id: '9098',
                        research_date: '2020-02-01',
                        reg_date: '2020-03-11',
                        feddistrict: 'Приволжский Федеральный округ',
                        region: 'Республика Чувашия',
                        municipal: 'Городской округ Город Чебоксары',
                    },
                    {
                        id_route: '777',
                        ref_section_id: '56765756',
                        research_date: '2020-02-01',
                        reg_date: '2020-03-11',
                        feddistrict: 'Приволжский Федеральный округ',
                        region: 'Республика Чувашия',
                        municipal: 'Городской округ Город Чебоксары',
                    },
                    {
                        id_route: '777',
                        ref_section_id: '1231231241',
                        research_date: '2020-02-01',
                        reg_date: '2020-03-11',
                        feddistrict: 'Приволжский Федеральный округ',
                        region: 'Республика Чувашия',
                        municipal: 'Городской округ Город Чебоксары',
                    },
                    {
                        id_route: '777',
                        ref_section_id: '346456754745',
                        research_date: '2020-02-01',
                        reg_date: '2020-03-11',
                        feddistrict: 'Приволжский Федеральный округ',
                        region: 'Республика Чувашия',
                        municipal: 'Городской округ Город Чебоксары',
                    },
                    {
                        id_route: '888',
                        ref_section_id: '346456754745',
                        research_date: '2020-02-01',
                        reg_date: '2020-03-11',
                        feddistrict: 'Приволжский Федеральный округ',
                        region: 'Республика Чувашия',
                        municipal: 'Городской округ Город Чебоксары',
                    },
                    {
                        id_route: '888',
                        ref_section_id: '346456754745',
                        research_date: '2020-02-01',
                        reg_date: '2020-03-11',
                        feddistrict: 'Приволжский Федеральный округ',
                        region: 'Республика Чувашия',
                        municipal: 'Городской округ Город Чебоксары',
                    },
                    {
                        id_route: '888',
                        ref_section_id: '346456754745',
                        research_date: '2020-02-01',
                        reg_date: '2020-03-11',
                        feddistrict: 'Приволжский Федеральный округ',
                        region: 'Республика Чувашия',
                        municipal: 'Городской округ Город Чебоксары',
                    },
                    {
                        id_route: '888',
                        ref_section_id: '346456754745',
                        research_date: '2020-02-01',
                        reg_date: '2020-03-11',
                        feddistrict: 'Приволжский Федеральный округ',
                        region: 'Республика Чувашия',
                        municipal: 'Городской округ Город Чебоксары',
                    },                        {
                        id_route: '888',
                        ref_section_id: '346456754745',
                        research_date: '2020-02-01',
                        reg_date: '2020-03-11',
                        feddistrict: 'Приволжский Федеральный округ',
                        region: 'Республика Чувашия',
                        municipal: 'Городской округ Город Чебоксары',
                    },
                    {
                        id_route: '888',
                        ref_section_id: '346456754745',
                        research_date: '2020-02-01',
                        reg_date: '2020-03-11',
                        feddistrict: 'Приволжский Федеральный округ',
                        region: 'Республика Чувашия',
                        municipal: 'Городской округ Город Чебоксары',
                    },                        {
                        id_route: '888',
                        ref_section_id: '346456754745',
                        research_date: '2020-02-01',
                        reg_date: '2020-03-11',
                        feddistrict: 'Приволжский Федеральный округ',
                        region: 'Республика Чувашия',
                        municipal: 'Городской округ Город Чебоксары',
                    },                        {
                        id_route: '888',
                        ref_section_id: '346456754745',
                        research_date: '2020-02-01',
                        reg_date: '2020-03-11',
                        feddistrict: 'Приволжский Федеральный округ',
                        region: 'Республика Чувашия',
                        municipal: 'Городской округ Город Чебоксары',
                    },                        {
                        id_route: '888',
                        ref_section_id: '346456754745',
                        research_date: '2020-02-01',
                        reg_date: '2020-03-11',
                        feddistrict: 'Приволжский Федеральный округ',
                        region: 'Республика Чувашия',
                        municipal: 'Городской округ Город Чебоксары',
                    },                        {
                        id_route: '888',
                        ref_section_id: '346456754745',
                        research_date: '2020-02-01',
                        reg_date: '2020-03-11',
                        feddistrict: 'Приволжский Федеральный округ',
                        region: 'Республика Чувашия',
                        municipal: 'Городской округ Город Чебоксары',
                    },                        {
                        id_route: '888',
                        ref_section_id: '346456754745',
                        research_date: '2020-02-01',
                        reg_date: '2020-03-11',
                        feddistrict: 'Приволжский Федеральный округ',
                        region: 'Республика Чувашия',
                        municipal: 'Городской округ Город Чебоксары',
                    },                        {
                        id_route: '888',
                        ref_section_id: '346456754745',
                        research_date: '2020-02-01',
                        reg_date: '2020-03-11',
                        feddistrict: 'Приволжский Федеральный округ',
                        region: 'Республика Чувашия',
                        municipal: 'Городской округ Город Чебоксары',
                    },
                    {
                        id_route: '888',
                        ref_section_id: '346456754745',
                        research_date: '2020-02-01',
                        reg_date: '2020-03-11',
                        feddistrict: 'Приволжский Федеральный округ',
                        region: 'Республика Чувашия',
                        municipal: 'Городской округ Город Чебоксары',
                    },
                    {
                        id_route: '888',
                        ref_section_id: '346456754745',
                        research_date: '2020-02-01',
                        reg_date: '2020-03-11',
                        feddistrict: 'Приволжский Федеральный округ',
                        region: 'Республика Чувашия',
                        municipal: 'Городской округ Город Чебоксары',
                    }



                ]
            }
        }


    }
</script>

<style lang="css" scoped>

</style>