import _ from 'lodash';

function createChild() {
    var element = document.createElement('div');
    element.innerHTML = _.join(['Hello', 'Webpack'], ' ');
    return element;
}

document.body.appendChild(createChild());