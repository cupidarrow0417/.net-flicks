<div class="alert alert-warning">
    This guide still needs a lot of work
</div>

# Minimal Requirements

1. jQuery
2. Moment.js
3. Locales: Moment's locale files are [here](https://github.com/moment/moment/tree/master/locale)

# Installation Guides
* [CDN](#cdn)
* [Nuget](#nuget)
* [Rails](#rails-)
* [Angular](#angular-wrapper)
* [Meteor.js](#meteorjs)
* [Manual](#manual)

## CDN
```html
<head>
  <script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/tempusdominus-bootstrap-4/5.0.0-alpha14/js/tempusdominus-bootstrap-4.min.js"></script>
  <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/tempusdominus-bootstrap-4/5.0.0-alpha14/css/tempusdominus-bootstrap-4.min.css" />
</head>
```

## Package Managers

### Nuget

### [Tempus.Dominus.Bootstrap.4](https://www.nuget.org/packages/Tempus.Dominus.Bootstrap.4/): ![NuGet version](https://badge.fury.io/nu/Tempus.Dominus.Bootstrap.4.png)

    PM> Install-Package Tempus.Dominus.Bootstrap.4


```html
<head>
  <script type="text/javascript" src="/scripts/jquery.min.js"></script>
  <script type="text/javascript" src="/scripts/moment.min.js"></script>
  <script type="text/javascript" src="/scripts/tempusdominus/tempusdominus-bootstrap-4.js"></script>
</head>
```

### Rails

Rails 5.1 Support - [Bootstrap 4 Datetime Picker Rails](https://github.com/Bialogs/bootstrap4-datetime-picker-rails)

1. Add `gem 'bootstrap4-datetime-picker-rails'` to your `Gemfile`
2. Execute `bundle`
3. Add `//= require tempusdominus-bootstrap-4.js` to your `application.js`
4. Add `@import "tempusdominus-bootstrap-4.css"` to your `application.scss`

### Angular Wrapper
Need new wrapper for this version.

### Meteor.js

Need new wrapper for this version.

## Manual

1. Acquire [jQuery](http://jquery.com)
2. Acquire [Moment.js](https://github.com/moment/moment)
3. Acquire
```html
<script type="text/javascript" src="/path/to/jquery.js"></script>
<script type="text/javascript" src="/path/to/moment.js"></script>
<script type="text/javascript" src="/path/to/tempusdominus-bootstrap-4.min.js"></script>
```

## Knockout

Need new wrapper for this version.
