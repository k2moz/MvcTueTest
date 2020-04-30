<template>
    <v-data-table
            :headers="headers"
            :items="spuobservations"
            class="elevation-1"
    >

        <template v-slot:item.approve_scheme="{ item }">
            <v-chip :color="getSchemaColor(item.approve_scheme)" dark>{{ item.approve_scheme }}</v-chip>
        </template>
        <template v-slot:item.approve_results="{ item }">
            <v-chip :color="getResultsColor(item.approve_results)" dark>{{ item.approve_results }}</v-chip>
        </template>
        <v-footer  fixed  width="80%" color="#FFFFFF">
            <v-btn class="float-right primary">Создать результаты обследования</v-btn>
        </v-footer>
    </v-data-table>

</template>

<script>
    export default {
        data () {
            return {
                headers: [
                    { text: 'Статус', value: 'pin_icon' },
                    {
                        text: 'Идентификатор обследования',
                        align: 'start',
                        sortable: true,
                        value: 'intersection_id',
                    },
                    {
                        text: 'Наименование участка',
                        align: 'start',
                        sortable: true,
                        value: 'intersection',
                    },
                    {
                        text: 'Идентификационный номер',
                        align: 'start',
                        sortable: true,
                        value: 'observation_id',
                    },
                    {
                        text: 'Дата редактирования схемы перекрестка',
                        align: 'start',
                        sortable: true,
                        value: 'editscheme_date',
                    },
                    {
                        text: 'Дата проведения обследования',
                        align: 'start',
                        sortable: true,
                        value: 'observation_date',
                    },
                    { text: 'Схема подтверждена', value: 'approve_scheme' },
                    { text: 'Результаты подтверждены', value: 'approve_results' },
                    { text: 'Действия', value: 'iron' },
                    { text: 'Федеральный округ', value: 'fat' },
                    { text: 'Субъект РФ', value: 'carbs' },
                    { text: 'Муниципальное образование', value: 'protein' },
                ],
                spuobservations: [
                    {
                        pin_icon: '',
                        intersection_id: 'Frozen Yogurt',
                        intersection: 'Перекресток',
                        observation_id: 'Обследование',
                        editscheme_date: '08.04.2020',
                        observation_date: '10.04.2020',
                        approve_scheme: 'Нет',
                        approve_results: 'Нет',
                        fat: 6.0,
                        carbs: 24,
                        protein: 4.0,
                        iron: '1%',
                    },
                    {
                        pin_icon: '',
                        intersection_id: 'Ice cream sandwich',
                        intersection: 'Перекресток',
                        observation_id: 'Обследование',
                        editscheme_date: '08.04.2020',
                        observation_date: '10.04.2020',
                        approve_scheme: 'Нет',
                        approve_results: 'Да',
                        fat: 9.0,
                        carbs: 37,
                        protein: 4.3,
                        iron: '1%',
                    },
                    {
                        pin_icon: '',
                        intersection_id: 'Eclair',
                        intersection: 'Перекресток',
                        observation_id: 'Обследование',
                        editscheme_date: '08.04.2020',
                        observation_date: '10.04.2020',
                        approve_scheme: 'Да',
                        approve_results: 'Да',
                        fat: 16.0,
                        carbs: 23,
                        protein: 6.0,
                        iron: '7%',
                    },
                    {
                        pin_icon: '',
                        intersection_id: 'Cupcake',
                        intersection: 'Перекресток',
                        observation_id: 'Обследование',
                        editscheme_date: '08.04.2020',
                        observation_date: '10.04.2020',
                        approve_scheme: 'Нет',
                        approve_results: 'Нет',
                        fat: 3.7,
                        carbs: 67,
                        protein: 4.3,
                        iron: '8%',
                    },
                    {
                        pin_icon: '',
                        intersection_id: 'Gingerbread',
                        intersection: 'Перекресток',
                        observation_id: 'Обследование',
                        editscheme_date: '08.04.2020',
                        observation_date: '10.04.2020',
                        approve_scheme: 'Да',
                        approve_results: 'Да',
                        fat: 16.0,
                        carbs: 49,
                        protein: 3.9,
                        iron: '16%',
                    },
                    {
                        pin_icon: '',
                        intersection_id: 'Jelly bean',
                        intersection: 'Перекресток',
                        observation_id: 'Обследование',
                        editscheme_date: '08.04.2020',
                        observation_date: '10.04.2020',
                        approve_scheme: 'Да',
                        approve_results: 'Да',
                        fat: 0.0,
                        carbs: 94,
                        protein: 0.0,
                        iron: '0%',
                    },
                    {
                        pin_icon: '',
                        intersection_id: 'Lollipop',
                        intersection: 'Перекресток',
                        observation_id: 'Обследование',
                        editscheme_date: '08.04.2020',
                        observation_date: '10.04.2020',
                        approve_scheme: 'Да',
                        approve_results: 'Да',
                        fat: 0.2,
                        carbs: 98,
                        protein: 0,
                        iron: '2%',
                    },
                    {
                        pin_icon: '',
                        intersection_id: 'Honeycomb',
                        intersection: 'Перекресток',
                        observation_id: 'Обследование',
                        editscheme_date: '08.04.2020',
                        observation_date: '10.04.2020',
                        approve_scheme: 'Да',
                        approve_results: 'Нет',
                        fat: 3.2,
                        carbs: 87,
                        protein: 6.5,
                        iron: '45%',
                    },
                    {
                        pin_icon: '',
                        intersection_id: 'Donut',
                        intersection: 'Перекресток',
                        observation_id: 'Обследование',
                        editscheme_date: '08.04.2020',
                        observation_date: '10.04.2020',
                        approve_scheme: 'Нет',
                        approve_results: 'Да',
                        fat: 25.0,
                        carbs: 51,
                        protein: 4.9,
                        iron: '22%',
                    },
                    {
                        pin_icon: '',
                        intersection_id: 'KitKat',
                        intersection: 'Перекресток',
                        observation_id: 'Обследование',
                        editscheme_date: '08.04.2020',
                        observation_date: '10.04.2020',
                        approve_scheme: 'Да',
                        approve_results: 'Нет',
                        fat: 26.0,
                        carbs: 65,
                        protein: 7,
                        iron: '6%',
                    },
                    {
                        pin_icon: '',
                        intersection_id: 'KitKat',
                        intersection: 'Перекресток',
                        observation_id: 'Обследование',
                        editscheme_date: '08.04.2020',
                        observation_date: '10.04.2020',
                        approve_scheme: 'Да',
                        approve_results: 'Нет',
                        fat: 26.0,
                        carbs: 65,
                        protein: 7,
                        iron: '6%',
                    },
                    {
                        pin_icon: '',
                        intersection_id: 'KitKat',
                        intersection: 'Перекресток',
                        observation_id: 'Обследование',
                        editscheme_date: '08.04.2020',
                        observation_date: '10.04.2020',
                        approve_scheme: 'Да',
                        approve_results: 'Нет',
                        fat: 26.0,
                        carbs: 65,
                        protein: 7,
                        iron: '6%',
                    },
                ],
            }
        },
        methods: {
            getSchemaColor (approve_scheme) {
                if (approve_scheme === 'Да') return 'green'
                // else if (approve_scheme > 200) return 'orange'
                else return 'red'
            },
            getResultsColor (approve_results) {
                if (approve_results === 'Да') return 'green'
                // else if (approve_scheme > 200) return 'orange'
                else return 'red'
            },
            getPinColor (approve_scheme, approve_results) {
                if (approve_scheme === 'Да' && approve_results === 'Да') return 'green'
                // else if (approve_scheme > 200) return 'orange'
                else return 'red'
            },
        },
    }
</script>