import { Component } from 'react';
import './Players.css';

class Players extends Component {
    constructor(props) {
        super(props);
        this.state = {
            error: null,
            isLoaded: false,
            players: []
        };
    }

    componentDidMount() {
        fetch("https://localhost:44326/players")
            .then(res => res.json())
            .then(
                (result) => {
                    console.log(result);
                    this.setState({
                        isLoaded: true,
                        players: result
                    });
                },
                // Note: it's important to handle errors here
                // instead of a catch() block so that we don't swallow
                // exceptions from actual bugs in components.
                (error) => {
                    this.setState({
                        isLoaded: true,
                        error
                    });
                }
            )
    }

    render() {
        const { error, isLoaded, players } = this.state;
        if (error) {
            return <div>Error: {error.message}</div>;
        } else if (!isLoaded) {
            return <div>Loading...</div>;
        } else {
            return (
                <div>
                    {players.map(player => (
                        <div class="card">
                        <img src="img_avatar.png" alt="Avatar" />
                        <div class="container">
                          <h4><b>{player.firstName} {player.lastName}</b></h4>
                          <p>{player.gender}</p>
                        </div>
                      </div>
                    ))}
                </div>
            );
        }
    }
}

export default Players;