/*
Template Name: Silva - Responsive Bootstrap 5 Admin Dashboard
Author: Zoyothemes
Version: 1.0.0
Website: https://zoyothemes.com/
File: CRM dashboard init Js
*/

// sale Overview

var options = {
    series: [{
        name: 'Profit',
        data: [7100, 6100, 3800, 5100, 7700, 9100, 6000, 7600, 3600, 5600, 7600, 8100]
    }, {
        name: 'Expense',
        data: [2500, 3800, 6000, 4800, 2200, 800, 3900, 2200, 6200, 4300, 2300, 1600]
    }],
    chart: {
        type: 'bar',
        height: 353,
        parentHeightOffset: 0,
        stacked: true,
        toolbar: {
            show: false
        }
    },
    plotOptions: {
        bar: {
            horizontal: false,
            columnWidth: '30%',
            startingShape: "rounded",
            endingShape: "rounded",
            borderRadius: 4,
        },
    },
    dataLabels: {
        enabled: false
    },
    xaxis: {
        categories: ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec'],
    },
    grid: {
        show: true,
        padding: {
            top: -18,
            right: 0,
            bottom: 0,
        },
        strokeDashArray: 4,
        xaxis: {
            lines: {
                show: true,
            },
        },
        yaxis: {
            lines: {
                show: false,
            },
        },
    },

    legend: {
        position: 'bottom',
    },
    fill: {
        opacity: 1
    },
    colors: ["#287F71", "#dee2e6"],
}
var chart = new ApexCharts(document.querySelector("#sales-overview"), options);
chart.render();


// Recent order
var options = {
    chart: {
        height: 300,
        type: 'radialBar',
    },
    plotOptions: {
        radialBar: {
            startAngle: -135,
            endAngle: 135,
            dataLabels: {
                name: {
                    fontSize: '13px',
                    color: undefined,
                    offsetY: 25,
                },
                value: {
                    offsetY: -15,
                    fontSize: '25px',
                    color: "#343a40",
                    formatter: function (val) {
                        return val + "%";
                    }
                }
            },

        }
    },
    fill: {
        gradient: {
            enabled: true,
            shade: 'dark',
            shadeIntensity: 0.2,
            inverseColors: false,
            opacityFrom: 1,
            opacityTo: 1,
            stops: [0, 50, 65, 91]
        },
    },
    stroke: {
        dashArray: 7
    },
    colors: ["#287F71", "#22c55e"],
    series: [78],
    labels: ['Growth']
}
var chart = new ApexCharts(document.querySelector("#browservisiting"), options);
chart.render();


// Deals Statistics
var options = {
    series: [
        {
            name: 'Top Lead',
            data: [80, 50, 30, 40, 100, 20],
        }, {
            name: 'Cold Lead',
            data: [20, 30, 40, 80, 20, 80],
        },
        {
            name: 'Qualified',
            data: [44, 76, 78, 13, 43, 10],
        }
    ],
    chart: {
        type: 'radar',
        height: 323,
        parentHeightOffset: 0,
        dropShadow: {
            enabled: true,
            blur: 1,
            left: 1,
            top: 1
        },
        toolbar: {
            show: false
        },
    },
    stroke: {
        width: 1,
    },
    fill: {
        opacity: 0.1
    },
    markers: {
        size: 3,
        hover: {
            size: 4
        }
    },
    yaxis: {
        stepSize: 20
    },
    tooltip: {
        y: {
            formatter: function (val) {
                return val
            }
        }
    },
    legend: {
        show: true,
    },
    xaxis: {
        categories: ['2019', '2020', '2021', '2022', '2023', '2024'],
        labels: {
            show: true,
            style: {
                colors: ["#001b2f", "#001b2f", "#001b2f", "#001b2f", "#001b2f", "#001b2f"],
                fontSize: "13px",
            }
        }
    },
    colors: ["#287F71", "#963b68", "#2786f1"],
    dataLabels: {
        enabled: false,
        background: {
            enabled: true,
        }
    }
    
};
var chart = new ApexCharts(document.querySelector("#deals-statistics"), options);
chart.render();



// Product Activity
var options = {
    chart: {
        height: 200,
        type: "donut"
    },
    plotOptions: {
        pie: {
            donut: {
                size: "75%"
            }
        }
    },
    dataLabels: {
        enabled: false
    },
    stroke: {
        show: true,
        width: 2,
        colors: ["transparent"]
    },
    series: [35, 35, 30],
    legend: {
        show: false,
        position: "bottom",
        horizontalAlign: "center",
        verticalAlign: "middle",
        floating: false,
        fontSize: "14px",
        offsetX: 0,
        offsetY: 0
    },
    labels: ["Mobile", "Tablet", "Desktop"],
    colors: ["#963b68", "rgba(150, 59, 104, .5)", "rgba(150, 59, 104, .18)"],
};
var chart = new ApexCharts(document.querySelector("#productactivity"), options);
chart.render();