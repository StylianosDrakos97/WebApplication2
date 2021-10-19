import React, { Component } from 'react';

export class FetchData extends Component {
  static displayName = FetchData.name;

  constructor(props) {
    super(props);
      this.state = { Shipwrecks: [], loading: true };
  }

  componentDidMount() {
    this.populateWeatherData();
  }

    static renderForecastsTable(Shipwrecks) {
    return (
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
          <tr>
                    <th>FeatureType</th>
                    <th>Chart</th>
                    <th>Latitude</th>
                    <th>Longitude</th>
          </tr>
        </thead>
            <tbody>
                {Shipwrecks.map(Shipwreck =>
                    <tr key={Shipwreck.Id}>
                        <td>{Shipwreck.FeatureType}</td>
                        <td>{Shipwreck.Chart}</td>
                        <td>{Shipwreck.Latitude}</td>
                        <td>{Shipwreck.Longitude}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
        : FetchData.renderForecastsTable(this.state.Shipwrecks);

    return (
      <div>
        <h1 id="tabelLabel" >Shipwreck Table</h1>
        <p>This component demonstrates fetching data from the server.</p>
        {contents}
      </div>
    );
  }

  async populateWeatherData() {
    const response = await fetch('weatherforecast');
    const data = await response.json();
    this.setState({ Shipwrecks: data, loading: false });
  }
}
