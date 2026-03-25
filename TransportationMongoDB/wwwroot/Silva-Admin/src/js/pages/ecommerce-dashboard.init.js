/*
Template Name: Silva - Responsive Bootstrap 5 Admin Dashboard
Author: Zoyothemes
Version: 1.0.0
Website: https://zoyothemes.com/
File: dashboard init Js
*/


// =================================================
// New Order
// =================================================
var options = {
    series: [
        {
            data: [40, 55, 40, 60, 48, 28, 56, 60],
        },
    ],
    chart: {
        height: 45,
        width: 100,
        type: "bar",
        sparkline: {
            enabled: true,
        },
        animations: {
            enabled: false
        },
    },
    colors: ["#287F71"],
    plotOptions: {
        bar: {
            columnWidth: "40%",
            borderRadius: 2,
        },
    },
    dataLabels: {
        enabled: false,
    },
    fill: {
        opacity: 1,
    },
    grid: {
        strokeDashArray: 4,
    },
    labels: [1, 2, 3, 4, 5, 6, 7, 8],
    xaxis: {
        crosshairs: {
            width: 1,
        },
    },
    yaxis: {
        labels: {
            padding: 0
        },
    },
    tooltip: {
        theme: 'light'
    },
    legend: {
        show: false,
    },
};
var chart = new ApexCharts(document.querySelector("#new-orders"), options);
chart.render();


// Monthly Orders
var options = {
    series: [68],
    chart: {
        height: 70,
        width: 70,
        parentHeightOffset: 0,
        type: "radialBar",
        offsetX: 0,
        offsetY: 8,
        sparkline: {
            enabled: true
        }
    },
    dataLabels: {
        enabled: false
    },
    colors: ["#963b68"],
    plotOptions: {
        radialBar: {
            offsetX: 7,
            offsetY: 0,
            margin: 0,
            hollow: {
                margin: 0,
                size: "70%",
                background: "#fff"
            },
            track: {
                margin: 0
            },
            dataLabels: {
                show: false
            }
        }
    },
    stroke: {
        lineCap: "round"
    }
};
var chart = new ApexCharts(document.querySelector("#monthly-orders"), options);
chart.render();


// Monthly Revenue
var options = {
    series: [
        {
            data: [40, 67, 55, 75, 65, 44, 30, 85],
        },
    ],
    chart: {
        height: 45,
        width: 100,
        type: "bar",
        sparkline: {
            enabled: true,
        },
        animations: {
            enabled: false
        },
    },
    colors: ["#73bbe2"],
    plotOptions: {
        bar: {
            columnWidth: "40%",
            borderRadius: 2,
        },
    },
    dataLabels: {
        enabled: false,
    },
    fill: {
        opacity: 1,
    },
    grid: {
        strokeDashArray: 4,
    },
    labels: [1, 2, 3, 4, 5, 6, 7, 8],
    xaxis: {
        crosshairs: {
            width: 1,
        },
    },
    yaxis: {
        labels: {
            padding: 0
        },
    },
    tooltip: {
        theme: 'light'
    },
    legend: {
        show: false,
    },
};
var chart = new ApexCharts(document.querySelector("#monthly-revenue"), options);
chart.render();


// Out Of Stock
var options = {
    series: [68],
    chart: {
        height: 70,
        width: 70,
        parentHeightOffset: 0,
        type: "radialBar",
        offsetX: 0,
        offsetY: 8,
        sparkline: {
            enabled: true
        }
    },
    dataLabels: {
        enabled: false
    },
    colors: ["#f59440"],
    plotOptions: {
        radialBar: {
            offsetX: 7,
            offsetY: 0,
            margin: 0,
            hollow: {
                margin: 0,
                size: "70%",
                background: "#fff"
            },
            track: {
                margin: 0
            },
            dataLabels: {
                show: false
            }
        }
    },
    stroke: {
        lineCap: "round"
    }
};
var chart = new ApexCharts(document.querySelector("#items-stock"), options);
chart.render();


// Sales Report
var options = {
    series: [
        {
            name: "2024",
            data: [1.8, 2.7, 1.9, 3.0, 2.1, 2.7, 2.2, 1.9, 2.5, 2.4, 1.5, 3.6],
        },
        {
            name: "2023",
            data: [-2.8, -1.8, -2.9, -2.2, -2.6, -2.3, -1.9, -2.5, -1.3, -1.0, -0.9, -1.8],
        },
    ],
    chart: {
        height: 360,
        type: "bar",
        stacked: true,
        offsetX: -15,
        foreColor: "#adb0bb",
        parentHeightOffset: 0,
        toolbar: {
            show: false,
        },
    },
    colors: ["#135046", "#cbe0dd"],
    plotOptions: {
        bar: {
            horizontal: false,
            barHeight: "60%",
            columnWidth: "20%",
            borderRadius: [6],
            borderRadiusApplication: "end",
            borderRadiusWhenStacked: "all",
        },
    },
    dataLabels: {
        enabled: false,
    },
    grid: {
        show: true,
        borderColor: "rgba(0,0,0,0.1)",
        strokeDashArray: 4,
        xaxis: {
            lines: {
                show: true,
            },
        },
        yaxis: {
            lines: {
                show: true,
            },
        },
    },
    yaxis: {
        min: -5,
        max: 5,
        title: {},
    },
    xaxis: {
        axisBorder: {
            show: false,
        },
        axisTicks: {
            show: false,
        },
        categories: [
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "July",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec",
        ],
        labels: {
            style: { fontSize: "13px", colors: "#adb0bb", fontWeight: "400" },
        },
    },
    yaxis: {
        tickAmount: 4,
    },
    tooltip: {
        x: {
            format: "dd/MM/yy HH:mm",
        },
        theme: "light",
    },
    legend: {
        show: true,
    },
};
var chart = new ApexCharts(document.querySelector("#chart-money"), options);
chart.render();


// Sales by Country
var options = {
    series: [
        {
            name: 'India',
            data: [80, 50, 30, 40, 100, 20],
        }, {
            name: 'Australia',
            data: [20, 30, 40, 80, 20, 80],
        }
    ],
    chart: {
        type: 'radar',
        height: 360,
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
        size: 0,
        hover: {
            size: 10
        }
    },
    yaxis: {
        stepSize: 20
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
    colors: ["#963b68", "#2786f1"],
    dataLabels: {
        enabled: true,
        background: {
            enabled: true,
            borderRadius: 2,
        }
    }
};
var chart = new ApexCharts(document.querySelector("#sales-country"), options);
chart.render();


// Repeat Customer Rate
var options = {
    series: [
        {
            name: "New Customer",
            data: [85, 80, 150, 127, 220, 200, 300, 290, 314]
        },
        {
            name: "Old Customer",
            data: [215, 165, 100, 200, 145, 185, 104, 124, 82]
        }
    ],
    chart: {
        type: 'line',
        height: 305,
        parentHeightOffset: 0,
        zoom: {
            enabled: false
        },
        toolbar: {
            show: false
        },
        animations: {
            enabled: false
        },
    },
    dataLabels: {
        enabled: false
    },
    fill: {
        opacity: 1,
    },
    stroke: {
        width: [2, 2],
        curve: 'straight',
        dashArray: [0, 7]
    },
    legend: {
        position: 'top',
        horizontalAlign: 'right',
        tooltipHoverFormatter: function (val, opts) {
            return val + ' <strong>' + opts.w.globals.series[opts.seriesIndex][opts.dataPointIndex] + '</strong>'
        }
    },
    markers: {
        size: 0,
        hover: {
            sizeOffset: 6
        }
    },
    grid: {
        strokeDashArray: 4,
        xaxis: {
            lines: {
                show: true
            }
        },
    },
    xaxis: {
        labels: {
            padding: 0,
        },
        axisBorder: {
            show: false,
        },
        tooltip: {
            enabled: false
        },
        categories: ['09', '10', '11', '12', '13', '14', '15', '16'],
    },
    tooltip: {
        y: [
            {
                title: {
                    formatter: function (val) {
                        return val
                    }
                }
            },
            {
                title: {
                    formatter: function (val) {
                        return val
                    }
                }
            }
        ]
    },
    colors: ["#537AEF", "#5be7bd"],
};
var chart = new ApexCharts(document.querySelector("#repeat-customer"), options);
chart.render();


// Orders Report Chart
var options = {
    series: [67],
    chart: {
        height: 248,
        type: 'radialBar',
        parentHeightOffset: 0,
    },
    colors: ["#73bbe2"],
    plotOptions: {
        radialBar: {
            startAngle: -135,
            endAngle: 135,
            dataLabels: {
                name: {
                    fontSize: '16px',
                    color: undefined,
                    offsetY: 10
                },
                value: {
                    offsetY: 0,
                    fontSize: '28px',
                    color: undefined,
                    formatter: function (val) {
                        return val + "%";
                    }
                }
            }
        }
    },
    fill: {
        type: 'gradient',
        gradient: {
            shade: 'dark',
            shadeIntensity: 0.15,
            inverseColors: false,
            opacityFrom: 1,
            opacityTo: 1,
            stops: [0, 50, 65, 91]
        },
    },
    stroke: {
        dashArray: 4
    },
    labels: [''],
};
var chart = new ApexCharts(document.querySelector("#ordersreport"), options);
chart.render();
