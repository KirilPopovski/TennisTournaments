import api from './api';

export const getAll = () => {
    return fetch(api.players, { mode: 'no-cors'})
        .then(res => res.json())
        .catch(err => console.log('Handled error:' + err));
};