<% Response.StatusCode = 404 %>

<!DOCTYPE html>
<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Error</title>
    <style>
        * {
            margin: 0;
            padding: 0;
        }

        body {
            font: 12px/1.2 "Helvetica Neue", Helvetica, Arial, sans-serif;
            color: #000;
            background: #fff;
        }

        .error-page {
            padding: 30px 20px 55px;
            width: 800px;
            margin: 0 auto;
        }

        .logo {
            /*text-transform: uppercase;*/
            font-size: 20px;
            font-weight: bold;
            text-align: center;
            background: #000;
            padding: 9px 17px;
            border-radius: 7px;
            margin: 0 auto 30px;
            overflow: hidden;
            position: relative;
            height: 24px;
            width: 150px;
            display: block;
            text-decoration: none;
            color: #FC0;
        }

        .error-number {
            font-size: 181px;
            line-height: 1;
            text-align: center;
            padding: 0 0 11px;
        }

        .error-text {
            font-size: 12pt;
            font-weight: 100;
            line-height: 1;
            text-align: center;
            padding: 0 0 11px;
            display: block;
        }
    </style>
</head>
<body>
    <div class="error-page">
        <a href="/" class="logo">The Blog</a>
        <h1 class="error-number">404</h1>
        <span class="error-text">...The Page Not Found</span>
    </div>
</body>
</html>
