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
            fetch('https://trinug-static-sites.azurewebsites.net/api/HogwartsData?code=N80Eu0QW/yjCpU0dqIafbfElqYiFoYsCY9deZXnwOwa3FntNaoGWUw==').then(response => response.json()).then(json => {
                this.people = json;
            });
        }
    }
});