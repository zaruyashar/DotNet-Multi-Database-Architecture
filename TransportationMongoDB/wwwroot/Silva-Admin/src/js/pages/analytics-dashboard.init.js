/*
Template Name: Silva - Responsive Bootstrap 5 Admin Dashboard
Author: Zoyothemes
Version: 1.0.0
Website: https://zoyothemes.com/
File: dashboard init Js
*/

// Website Traffic Chart
var options = {
    series: [
        {
            data: [15, 25, 20, 35, 60, 30, 20, 30, 20, 35, 25, 20, 55, 45, 22],
        },
    ],
    chart: {
        height: 45,
        type: "bar",
        sparkline: {
            enabled: true,
        },
        animations: {
            enabled: false
        },
    },
    colors: ["#135046", "#cbe0dd"],
    plotOptions: {
        bar: {
            columnWidth: "50%",
            distributed: true,
            borderRadius: 3,
            barHeight: '38%',
            dataLabels: {
                position: 'top',
            },
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
    labels: [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15],
    xaxis: {
        crosshairs: {
            width: 1,
        },
    },
    yaxis: {
        labels: {
            padding: 4
        },
    },
    tooltip: {
        theme: 'light'
    },
    legend: {
        show: false,
    },
};
var chart = new ApexCharts(document.querySelector("#website-traffic"), options);
chart.render();


// Conversion Chart
var options = {
    series: [{
        name: "Desktops",
        data: [25, 25, 55, 55, 20, 20, 60, 60, 35, 35, 60, 60, 15, 15],
    }],
    chart: {
        height: 45,
        type: 'area',
        sparkline: {
            enabled: true,
        },
        animations: {
            enabled: false
        },
        dropShadow: {
            enabled: true,
            top: 10,
            left: 0,
            bottom: 10,
            blur: 2,
            color: "#f0f4f7",
            opacity: 0.3,
        },
    },
    colors: ["#ec344c"],
    fill: {
        type: "gradient",
        gradient: {
            shadeIntensity: 1,
            opacityFrom: 0.5,
            opacityTo: 0.1,
            stops: [0, 90, 100]
        }
    },
    tooltip: {
        enabled: false
    },
    dataLabels: {
        enabled: false
    },
    grid: {
        show: false,
    },
    xaxis: {
        labels: {
            show: false,
        },
        axisBorder: {
            show: false,
        },
        axisTicks: {
            show: false,
        },
    },
    yaxis: {
        show: false,
    },
    stroke: {
        curve: 'straight',
        width: 2,
    },
};
var chartOne = new ApexCharts(document.querySelector('#conversion-visitors'), options);
chartOne.render();


// Session Duration Chart
var options = {
    series: [{
        name: "Desktops",
        data: [25, 25, 68, 68, 2, 2, 50, 50, 25, 25, 55, 55, 89, 89],
    }],
    chart: {
        height: 45,
        type: 'area',
        sparkline: {
            enabled: true,
        },
        animations: {
            enabled: false
        },
        dropShadow: {
            enabled: true,
            top: 10,
            left: 0,
            bottom: 10,
            blur: 2,
            color: "#f0f4f7",
            opacity: 0.3,
        },
    },
    colors: ["#287F71"],
    fill: {
        type: "gradient",
        gradient: {
            shadeIntensity: 1,
            opacityFrom: 0.5,
            opacityTo: 0.1,
            stops: [0, 90, 100]
        }
    },
    tooltip: {
        enabled: false
    },
    dataLabels: {
        enabled: false
    },
    grid: {
        show: false,
    },
    xaxis: {
        labels: {
            show: false,
        },
        axisBorder: {
            show: false,
        },
        axisTicks: {
            show: false,
        },
    },
    yaxis: {
        show: false,
    },
    stroke: {
        curve: 'straight',
        width: 2,
    },
};
var chartOne = new ApexCharts(document.querySelector('#session-duration'), options);
chartOne.render();


// Active Users Chart
var options = {
    series: [
        {
            data: [15, 25, 20, 35, 60, 30, 20, 30, 20, 35, 25, 20, 55, 45, 22],
        },
    ],
    chart: {
        height: 45,
        type: "bar",
        sparkline: {
            enabled: true,
        },
        animations: {
            enabled: false
        },
    },
    colors: ["#ec8290", "#2786f1"],
    plotOptions: {
        bar: {
            columnWidth: "50%",
            distributed: true,
            borderRadius: 3,
            barHeight: '38%',
            dataLabels: {
                position: 'top',
            },
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
    labels: [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15],
    xaxis: {
        crosshairs: {
            width: 1,
        },
    },
    yaxis: {
        labels: {
            padding: 4
        },
    },
    tooltip: {
        theme: 'light'
    },
    legend: {
        show: false,
    },
};
var chartOne = new ApexCharts(document.querySelector('#active-users'), options);
chartOne.render();


// Average Daily Sales Chart
var options = {
    chart: {
        height: 82,
        type: "area",
        toolbar: {
            show: false
        },
        sparkline: {
            enabled: true,
        },
    },
    markers: {
        colors: "transparent",
        strokeColors: "transparent"
    },
    colors: ["#287F71"],
    fill: {
        type: "gradient",
        gradient: {
            shade: 'light',
            shadeIntensity: 0.8,
            opacityFrom: 0.5,
            opacityTo: 0.3,
        }
    },
    dataLabels: {
        enabled: false
    },
    stroke: {
        width: 2,
        curve: 'smooth',
    },
    series: [{
        data: [400, 100, 650, 500]
    }],
    xaxis: {
        show: true,
        lines: {
            show: false,
        },
        stroke: {
            width: 0
        },
        labels: {
            show: false,
        },
        axisBorder: {
            show: false,
        },
    },
    yaxis: {
        stroke: {
            width: 0
        },
        show: false,
    },
    tooltip: {
        enabled: false
    },
    grid: {
        show: false,
    },
    responsive: [{
        breakpoint: 1387,
        options: {
            chart: {
                height: 80
            }
        }
    }, {
        breakpoint: 1200,
        options: {
            chart: {
                height: 123
            }
        }
    }]

};
var chartOne = new ApexCharts(document.querySelector('#average-daily-sales'), options);
chartOne.render();


// Earning Reports Chart
var options = {
    series: [
        {
            name: 'Earnings',
            type: "column",
            data: [180, 520, 376, 420, 520, 580, 435, 515, 480, 350, 310, 230],
        },
        {
            name: "Actions",
            type: "area",
            data: [180, 520, 376, 220, 520, 680, 235, 515, 738, 454, 525, 230],
        }],
    chart: {
        redrawOnWindowResize: true,
        parentHeightOffset: 0,
        height: 300,
        type: 'bar',
        toolbar: {
            show: false
        },
    },
    plotOptions: {
        bar: {
            horizontal: false,
            columnWidth: '25%',
            borderRadius: 2,
            colors: {
                ranges: [{
                    from: 400,
                    to: 500,
                    color: '#287F71'
                }, {
                    from: 0,
                    to: 40,
                    color: '#522c8f'
                }]
            },
        },
    },
    grid: {
        // borderColor: "#f1f1f1",
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
    dataLabels: {
        enabled: false
    },
    stroke: {
        width: [0, 2, 1.9],
        curve: "straight",
        dashArray: [0, 0, 6]
    },
    legend: {
        show: true,
        fontSize: "13px",
        position: 'top',
        horizontalAlign: 'right',
        fontWeight: 500,
        height: 40,
        offsetX: 0,
        offsetY: 20,
        labels: {
            colors: '#9ba5b7',
        },
        markers: {
            width: 7,
            height: 7,
            strokeWidth: 0,
            strokeColor: '#fff',
            fillColors: undefined,
            radius: 12,
            offsetX: 0,
            offsetY: 0
        },
    },
    colors: ["#287F71", "#287F71"],
    yaxis: {
        labels: {
            formatter: function (y) {
                return y.toFixed(0) + "";
            },
            show: true,
            style: {
                colors: "#001b2f",
                fontWeight: 500,
            },
        }
    },
    xaxis: {
        type: "month",
        categories: ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Agu', 'Sep', 'Oct', 'Nov', 'Dec'],
        axisBorder: {
            show: true,
            color: '#ced4da',
            offsetX: 0,
            offsetY: 0,
        },
        axisTicks: {
            show: true,
            borderType: 'solid',
            color: '#ced4da',
            width: 6,
            offsetX: 0,
            offsetY: 0
        },
        labels: {
            rotate: -90,
            style: {
                colors: "#001b2f",
                fontWeight: 500,
            },
        }
    },
    fill: {
        type: ['solid', 'gradient', 'solid'],
        gradient: {
            shadeIntensity: 1,
            opacityFrom: 0.4,
            opacityTo: 0.1,
            stops: [0, 90, 100],
            colorStops: [
                [
                    {
                        offset: 0,
                        color: "#287F71",
                        opacity: 1
                    },
                    {
                        offset: 75,
                        color: "#287F71",
                        opacity: 0.2
                    },
                    {
                        offset: 100,
                        color: '#287F71',
                        opacity: 0.4
                    }
                ],
                [
                    {
                        offset: 0,
                        color: "#287F71",
                        opacity: 0.1
                    },
                    {
                        offset: 75,
                        color: "#287F71",
                        opacity: 0.2
                    },
                    {
                        offset: 100,
                        color: '#287F71',
                        opacity: 0.4
                    }
                ],
                [
                    {
                        offset: 0,
                        color: '#287F71',
                        opacity: 1
                    },
                    {
                        offset: 75,
                        color: '#287F71',
                        opacity: 0.2
                    },
                    {
                        offset: 100,
                        color: '#287F71',
                        opacity: 0.4
                    }
                ],
            ]
        }
    },
    tooltip: {
        shared: true,
        intersect: false,
        y: {
            formatter: function (y) {
                if (typeof y !== "undefined") {
                    return y.toFixed(0);
                }
                return y;
            },
        },
    },
}
var chartOne = new ApexCharts(document.querySelector('#monthly-sales'), options);
chartOne.render();


// Total Leads
var options = {
    series: [{
        name: 'Created',
        data: [48, 32, 42, 28, 15, 32, 20]
    }, {
        name: 'Converted',
        data: [32, 33, 39, 42, 72, 55, 60]
    }],
    chart: {
        type: 'bar',
        height: 367,
        stacked: true,
        foreColor: "#adb0bb",
        parentHeightOffset: 0,
        toolbar: {
            show: false
        },
    },
    plotOptions: {
        bar: {
            horizontal: false,
            columnWidth: '20%',
            endingShape: "rounded",
            startingShape: "rounded",
        },
    },
    dataLabels: {
        enabled: false
    },
    xaxis: {
        categories: ['Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug'],
    },
    grid: {
        borderColor: "rgba(0,0,0,0.1)",
        strokeDashArray: 3,
        xaxis: {
            lines: {
                show: false,
            },
        },
        yaxis: {
            lines: {
                show: true,
            },
        },
    },
    colors: ["#c26316", "#D49664"],
    legend: {
        position: "bottom"
    },
    fill: {
        opacity: 1
    }
};
var chart = new ApexCharts(document.querySelector("#totalleads"), options);
chart.render();


// Top Session
var options = {
    series: [
        {
            name: "Chrome",
            data: [[30, 25, 50, 50]],
        },
        {
            name: "Firefox",
            data: [[10, 35, 55, 60]],
        },
        {
            name: "Safari",
            data: [[5, 15, 40, 50]],
        },
        {
            name: "Opera",
            data: [[20, 40, 65, 60]],
        },
        {
            name: "Chromium",
            data: [[20, 10, 55, 70]],
        },
    ],
    chart: {
        height: 333,
        type: "bubble",
        parentHeightOffset: 0,
        toolbar: {
            show: false,
        },
    },
    grid: {
        // borderColor: "rgba(0,0,0,0.1)",
        strokeDashArray: 3,
    },
    dataLabels: {
        enabled: false,
    },
    colors: ["#287F71", "#522c8f", "#f59440", "#73bbe2", "#73bbe2"],
    legend: {
        show: true,
        fontSize: "13px",
        labels: {
            colors: "#959595",
        },
        markers: {
            width: 10,
            height: 10,
        },
    },
    xaxis: {
        min: 0,
        max: 40,
        labels: {
            show: false,
        },
        axisBorder: {
            show: false,
        },
    },
    yaxis: {
        max: 50,
        labels: {
            show: false,
        },
    },
};
var chart = new ApexCharts(document.querySelector("#top-session"), options);
chart.render();