class EvaluationProgressBar extends React.Component {
    render() {
        return (
            <div className="card">
                <div className="card-body">
                    <div className="mb-4">
                        <h5 className="card-title">Vessel Quality</h5>
                        <div className="progress">
                            <div
                                className="progress-bar bg-success"
                                role="progressbar"
                                style={{ width: `${this.props.vesselQualityValue * 20}%` }}
                                aria-valuenow={this.props.vesselQualityValue * 20}
                                aria-valuemin="0"
                                aria-valuemax="100"
                            >
                                {this.props.vesselQualityValue}
                            </div>
                        </div>
                    </div>

                    <div className="mb-4">
                        <h5 className="card-title">Crew Performance</h5>
                        <div className="progress">
                            <div
                                className="progress-bar bg-info"
                                role="progressbar"
                                style={{ width: `${this.props.crewPerformanceValue * 20}%` }}
                                aria-valuenow={this.props.crewPerformanceValue * 20}
                                aria-valuemin="0"
                                aria-valuemax="100"
                            >
                                {this.props.crewPerformanceValue}
                            </div>
                        </div>
                    </div>

                    <div className="mb-4">
                        <h5 className="card-title">Crew Attitude</h5>
                        <div className="progress">
                            <div
                                className="progress-bar bg-warning"
                                role="progressbar"
                                style={{ width: `${this.props.crewAttitudeValue * 20}%` }}
                                aria-valuenow={this.props.crewAttitudeValue * 20}
                                aria-valuemin="0"
                                aria-valuemax="100"
                            >
                                {this.props.crewAttitudeValue}
                            </div>
                        </div>
                    </div>

                    <div className="mb-4">
                        <h5 className="card-title">Fuel Efficiency</h5>
                        <div className="progress">
                            <div
                                className="progress-bar bg-danger"
                                role="progressbar"
                                style={{ width: `${this.props.fuelEfficiencyValue * 20}%` }}
                                aria-valuenow={this.props.fuelEfficiencyValue * 20}
                                aria-valuemin="0"
                                aria-valuemax="100"
                            >
                                {this.props.fuelEfficiencyValue}
                            </div>
                        </div>
                    </div>

                    <div>
                        <h5 className="card-title">Safety Score</h5>
                        <div className="progress">
                            <div
                                className="progress-bar bg-primary"
                                role="progressbar"
                                style={{ width: `${this.props.safetyScoreValue * 20}%` }}
                                aria-valuenow={this.props.safetyScoreValue * 20}
                                aria-valuemin="0"
                                aria-valuemax="100"
                            >
                                {this.props.safetyScoreValue}
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}




