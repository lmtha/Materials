var express = require('express');
var router = express.Router();

/* GET users listing. */
router.get('/', function(req, res, next) {
  //res.send('respond with a resource');
  res.render('pages/items/list',{titlePage: 'List items'});
});
router.get('/add', function(req, res, next) {
  res.render('pages/items/add',{titlePage: 'Add items'});
});
module.exports = router;
