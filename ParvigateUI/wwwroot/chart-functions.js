function createVehicleChart(config) {
    const ctx = document.getElementById(config.chartId).getContext('2d');
    new Chart(ctx, {
        type: 'bar',
        data: {
            labels: config.labels,
            datasets: [{
                label: 'Number of Vehicles',
                data: config.data,
                backgroundColor: ['rgba(75, 192, 192, 0.2)', 'rgba(255, 99, 132, 0.2)'],
                borderColor: ['rgba(75, 192, 192, 1)', 'rgba(255, 99, 132, 1)'],
                borderWidth: 1
            }]
        },
        options: {
            responsive: true,
            maintainAspectRatio: false,
            title: {
                display: true,
                text: config.title
            },
            scales: {
                x: {
                    title: {
                        display: true,
                        text: 'Vehicle Type'
                    }
                },
                y: {
                    beginAtZero: true,
                    stepSize: 1,
                    title: {
                        display: true,
                        text: 'Count'
                    }
                }
            }
        }
    });
}

function createUserChart(config) {
    const ctx = document.getElementById(config.chartId).getContext('2d');
    new Chart(ctx, {
        type: 'pie',
        data: {
            labels: config.labels,
            datasets: [{
                label: 'User Roles',
                data: config.data,
                backgroundColor: ['rgba(255, 99, 132, 0.2)', 'rgba(75, 192, 192, 0.2)'],
                borderColor: ['rgba(255, 99, 132, 1)', 'rgba(75, 192, 192, 1)'],
                borderWidth: 1
            }]
        },
        options: {
            responsive: true,
            maintainAspectRatio: false,
            title: {
                display: true,
                text: config.title
            }
        }
    });
}
