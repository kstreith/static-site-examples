var app = new Vue({
    el: '#app',
    data: {
        people: []
    },
    mounted: function () {
        this.loadPeople();
    },
    methods: {
        loadPeople: function() {
            fetch('https://swapi.co/api/people').then(response => response.json()).then(json => {
                this.people = json.results || [];
            });
        }
    }
});