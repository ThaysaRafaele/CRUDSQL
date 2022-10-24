$(document).ready(function () {

    $('.date').mask('00/00/0000');
    $('.date_time').mask('00/00/0000 00:00:00');
    $('.txtCPF').mask('000.000.000-00', { reverse: true });
    $('.money').mask('######0.00', { reverse: true });
});